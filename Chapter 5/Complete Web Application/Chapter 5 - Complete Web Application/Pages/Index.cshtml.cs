using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using LaunchDarkly.Client;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace Chapter_5___Complete_Web_Application.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ILdClient _ldClient;

        // USED FOR THE FIRST EXAMPLE
        public string CtaLabel;

        public IndexModel(ILogger<IndexModel> logger, ILdClient ldClient)
        {
            _logger = logger;
            _ldClient = ldClient;
        }

        public void OnGet(string countryOverride)
        {
            // USED FOR THE SECOND EXAMPLE
            //var watch = new Stopwatch();
            //watch.Start();

            string country = string.IsNullOrEmpty(countryOverride) ? null : countryOverride;

            User user = GetUser(country);

            // USED FOR THE FIRST EXAMPLE
             CtaLabel = _ldClient.BoolVariation("registration-experiment", user, false) ? "Join today" : "Register";

            // USED FOR THE SECOND EXAMPLE
            //if (!_ldClient.BoolVariation("registration-experiment", user, false))
            //{
            //    System.Threading.Thread.Sleep(5000);
            //}
            //else
            //{ 
            //    // do nothing
            //}

            // USED FOR THE SECOND EXAMPLE
            //watch.Stop();
            //double metric = Convert.ToDouble(watch.ElapsedMilliseconds);
            //_ldClient.Track("page load time", user, LdValue.Null, metric);
        }

        private User GetUser(string country)
        {
            string ldHashCookieKey = "_ldhash";
            string guid;

            if (!Request.Cookies.ContainsKey(ldHashCookieKey))
            {
                guid = Guid.NewGuid().ToString();
                var cookieOptions = new CookieOptions()
                {
                    Path = "/",
                    Expires = DateTimeOffset.UtcNow.AddDays(365),
                    IsEssential = true,
                    HttpOnly = false,
                    Secure = false,
                };

                Response.Cookies.Append(ldHashCookieKey, guid, cookieOptions);
            }
            else
            {
                Request.Cookies.TryGetValue(ldHashCookieKey, out guid);
            }

            return LaunchDarkly.Client.User.Builder(guid)
                    .Country(country)
                    .FirstName("Michael")
                    .LastName("Gillett")
                    .Anonymous(false)
                    .Build();
        }
    }
}

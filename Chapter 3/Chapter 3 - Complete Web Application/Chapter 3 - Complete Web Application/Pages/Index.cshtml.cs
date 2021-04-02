using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using LaunchDarkly.Client;
using Microsoft.AspNetCore.Http;

namespace Chapter_3___Complete_Web_Application.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ILdClient _ldClient;
        public bool MyFirstFeatureFlagResult = false;

        public IndexModel(ILogger<IndexModel> logger, ILdClient ldClient)
        {
            _logger = logger;
            _ldClient = ldClient;
        }

        public void OnGet(string countryOverride)
        {
            string country = string.IsNullOrEmpty(countryOverride) ? null : countryOverride;

            User user = GetUser(country);
            MyFirstFeatureFlagResult = _ldClient.BoolVariation("my-first-feature-flag", user, false);
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
                    .Anonymous(true)
                    .Build();
        }
    }
}

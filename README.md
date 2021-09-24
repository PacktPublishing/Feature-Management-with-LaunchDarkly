# Feature Management with LaunchDarkly

<a href="https://www.packtpub.com/product/feature-management-with-launchdarkly/9781800562974?utm_source=github&utm_medium=repository&utm_campaign=9781800562974"><img src="https://static.packt-cdn.com/products/9781800562974/cover/smaller" alt="Feature Management with LaunchDarkly" height="256px" align="right"></a>

This is the code repository for [Feature Management with LaunchDarkly](https://www.packtpub.com/product/feature-management-with-launchdarkly/9781800562974?utm_source=github&utm_medium=repository&utm_campaign=9781800562974), published by Packt.

**Discover safe ways to make live changes in your systems and master testing in production**

## What is this book about?
Over the past few years, DevOps has become the de facto approach for designing, building, and delivering software. Feature management is now extending the DevOps methodology to allow applications to change on demand and run experiments to validate the success of new features. If you want to make feature management happen, LaunchDarkly is the tool for you. 

This book covers the following exciting features:
* Get to grips with the basics of LaunchDarkly and feature flags
* Roll out a feature to a percentage or group of users
* Find out how to experiment with multi-variant and A/B testing
* Discover how to adopt a trunk-based development workflow
* Explore methods to manage infrastructure changes and migrations
* Gain an in-depth understanding of all aspects of the LaunchDarkly tool

If you feel this book is for you, get your [copy](https://www.amazon.com/dp/1800562977) today!

<a href="https://www.packtpub.com/?utm_source=github&utm_medium=banner&utm_campaign=GitHubBanner"><img src="https://raw.githubusercontent.com/PacktPublishing/GitHub/master/GitHub.png" 
alt="https://www.packtpub.com/" border="5" /></a>

## Instructions and Navigations
All of the code is organized into folders. For example, Chapter02.

The code will look like the following:
```
public void OnGet()
{
  User user = LaunchDarkly.Client.User.Builder(Guid.
     NewGuid().ToString())
  .Anonymous(true)
  .Build();
}
```

**Following is what you need for this book:**
This book is for developers, quality assurance engineers and DevOps engineers. This includes individuals who want to decouple the deployment of code from the release of a feature, run experiments in production, or understand how to change processes to build and deploy software. Software engineers will also benefit from learning how feature management can be used to improve products and processes. A basic understanding of software is all that you need to get started with this book as it covers the basics before moving on to more advanced topics.

With the following software and hardware list you can run all code files present in the book (Chapter 1-13).
### Software and Hardware List
| Chapter | Software required | OS required |
| -------- | ------------------------------------ | ----------------------------------- |
| 1-13 | Git | Windows, Mac OS X, and Linux (Any) |
| 1-13 | Visual Studio 2019 OR Visual Studio Code | Windows, Mac OS X, and Linux (Any) |
| 1-13 | .NET 5 | Windows, Mac OS X, and Linux (Any) |
| 1-13 | LaunchDarkly SDK | Windows, Mac OS X, and Linux (Any) |

We also provide a PDF file that has color images of the screenshots/diagrams used in this book. [Click here to download it](https://static.packt-cdn.com/downloads/9781800562974_ColorImages.pdf).

### Related products
* DevOps Adoption Strategies: Principles, Processes, Tools, and Trends [[Packt]](https://www.packtpub.com/product/devops-adoption-strategies-principles-processes-tools-and-trends/9781801076326?utm_source=github&utm_medium=repository&utm_campaign=9781801076326) [[Amazon]](https://www.amazon.com/dp/1801076324)

* The DevOps 2.5 Toolkit [[Packt]](https://www.packtpub.com/product/the-devops-2-5-toolkit/9781838647513?utm_source=github&utm_medium=repository&utm_campaign=9781838647513) [[Amazon]](https://www.amazon.com/dp/1793010536)

## Get to Know the Author
**Michael Gillett**
is a head of development and a full-stack software engineer residing in London, UK. He has worked with feature management and LaunchDarkly for several years and has defined processes and techniques to enable teams to get the most from this approach to software delivery. He often talks on this subject at conferences and events.
Michael graduated from the University of Hertfordshire with an MSc in computer science and a BEng in electrical and electronic engineering in 2012. Since 2012 Michael has been a Microsoft MVP, currently in the Windows Insider category

# Chapter 5

## Technical requirements

The Chapter 5 examples were created with Visual Studio 2019 on a Windows PC and in C# and .NET 5. The samples have been tested in Visual Studio 2019 and Visual Studio Code on a Windows PC.

### Complete Web Application

Use this code sample to see the completed project working as expected. You will need to open the Startup.cs file and navigate to line 28: 

```
services.AddSingleton<ILdClient>(new LdClient("YOUR_SDK_KEY"));
```

You need to replace _YOUR_SDK_KEY_ with the LaunchDarkly SDK for your account.

- If using __Visual Studio 2019__ open the _Feature-Management-with-LaunchDarkly\Chapter 5\Complete Web Application_ directory and run the application.

- If using __Visual Studio Code__ open the _Feature-Management-with-LaunchDarkly\Chapter 5\Complete Web Application\Chapter 5 - Complete Web Application_ directory and run the application.

The changes detailed in Chapter 5 are found in the Pages/Index.cs and Pages/Index.cshtml files.
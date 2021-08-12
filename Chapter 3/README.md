# Chapter 3

## Technical requirements

The Chapter 3 examples were created with Visual Studio 2019 on a Windows PC and in C# and .NET 5. The samples have been tested in Visual Studio 2019 and Visual Studio Code on a Windows PC.

### Blank Web Application

Use this code sample to follow along with the instructions in the chapter. You can immediately run this sample application

- If using __Visual Studio 2019__ open the _Feature-Management-with-LaunchDarkly\Chapter 3\Blank Web Application_ directory and run the application.

- If using __Visual Studio Code__ open the _Feature-Management-with-LaunchDarkly\Chapter 3\Blank Web Application\Chapter 3 - Blank Web Application_ directory and run the application.

### Complete Web Application

Use this code sample to see the completed project working as expected. You will need to open the Startup.cs file and navigate to line 28: 

```
services.AddSingleton<ILdClient>(new LdClient("YOUR_SDK_KEY"));
```

You need to replace _YOUR_SDK_KEY_ with the LaunchDarkly SDK for your account.

- If using __Visual Studio 2019__ open the _Feature-Management-with-LaunchDarkly\Chapter 3\Complete Web Application_ directory and run the application.

- If using __Visual Studio Code__ open the _Feature-Management-with-LaunchDarkly\Chapter 3\Complete Web Application\Chapter 3 - Complete Web Application_ directory and run the application.
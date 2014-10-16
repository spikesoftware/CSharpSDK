CSharpSDK
=========

SDK for C#/.net environments other than Unity, including Microsoft CLR environments, Mono and Xamarin.

# SDKs

This package contains three different versions of the PlayFab SDK. 

PlayFabClientSDK - This version contains only client libraries and is designed for integration with your game client
PlayFabServerSDK - Contains server and admin APIs designed to be called from your custom logic server or build process
PlayFabSDK - Contains all APIs in one SDK.

# Integration

To integrate the PlayFab SDK into your cocos2d-x project, follow these steps.

1. Determine which version of the SDK you need for your project. From that version, Add all the .cs files under PlayFabClientSDK/source to your project.
2. Add a reference to Newtonsoft.Json to your project. In VS, this can be done through NuGet Manager by searching for Json.NET. In Xamarin Studio, you can search for Json.NET in the Component Store.

Done!

# API Docs

Please see http://api.playfab.com/Documentation/ for complete documentation of all PlayFab SDK calls.
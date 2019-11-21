# xamarin.tvos.appcenter

Xamarin.tvOS C# Bindings for the AppCenter tvOS native framework. This allows you to add App Center Crashes and Analytics to your Xamarin.tvOS app. 


References :

- [App Center](appcenter.ms)
- [App Center Diagnostics tvOS](https://docs.microsoft.com/en-us/appcenter/sdk/crashes/tvos)
- [App Center Analytics tvOS](https://docs.microsoft.com/en-us/appcenter/sdk/analytics/tvos)


Download AppCenter Framework : https://github.com/Microsoft/AppCenter-SDK-Apple/releases

## Note
Works for Device only currently, if you build for simulator, you will get lots of errors and you will cry. Build with target to Device, and be happy.

To test Crashes using the `GenerateTestCrash()` method, note that it does *NOT* work if debugger is attached. So either build the app in Release mode or turn off debugger in Options before testing the Crashes portion. 

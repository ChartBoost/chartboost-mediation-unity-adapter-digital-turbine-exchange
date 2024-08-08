# Chartboost Mediation Unity SDK - Digital Turbine Exchange Adapter

Provides a list of externally configurable properties pertaining to the partner SDK that can be retrieved and set by publishers. 

Dependencies for the adapter are now embedded in the package, and can be found at `com.chartboost.mediation.unity.adapter.digital-turbine-exchange/Editor/DigitalTurbineExchangeAdapterDependencies.xml`.

# Installation

## Using the public [npm registry](https://www.npmjs.com/search?q=com.chartboost.mediation.unity.adapter.digital-turbine-exchange)

In order to add the Chartboost Mediation Unity SDK - Digital Turbine Exchange Adapter to your project using the npm package, add the following to your Unity Project's ***manifest.json*** file. The scoped registry section is required in order to fetch packages from the NpmJS registry.

```json
"dependencies": {
    "com.chartboost.mediation.unity.adapter.digital-turbine-exchange": "5.0.0",
    ...
},
"scopedRegistries": [
{
    "name": "NpmJS",
    "url": "https://registry.npmjs.org",
    "scopes": [
    "com.chartboost"
    ]
}
]
```
## Using the public [NuGet package](https://www.nuget.org/packages/Chartboost.CSharp.Mediation.Unity.Adapter.DigitalTurbineExchange)

To add the Chartboost Mediation Unity SDK - Digital Turbine Exchange Adapter to your project using the NuGet package, you will first need to add the [NugetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) package into your Unity Project.

This can be done by adding the following to your Unity Project's ***manifest.json***

```json
  "dependencies": {
    "com.github-glitchenzo.nugetforunity": "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity",
    ...
  },
```

Once <code>NugetForUnity</code> is installed, search for `Chartboost.CSharp.Mediation.Unity.Adapter.Digital Turbine Exchange` in the search bar of Nuget Explorer window(Nuget -> Manage Nuget Packages).
You should be able to see the `Chartboost.CSharp.Mediation.Unity.Adapter.DigitalTurbineExchange` package. Choose the appropriate version and install.

# AndroidManifest.xml Permissions
Apps that update their target API level to 31 (Android 12) must declare a Google Play Services permission in the manifest file as follows, unless the app uses a recent version of Google Mobile Ads SDK:

```xml
<uses-permission android:name="com.google.android.gms.permission.AD_ID"/>
```

Add the following mandatory permissions into your application's `AndroidManifest.xml`:

```xml
<uses-permission android:name="android.permission.INTERNET"/>
<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE"/>
```

Recommended permissions for better targeting

```xml
<uses-permission android:name="android.permission.ACCESS_FINE_LOCATION"/>
<uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION"/>
<uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE"/>
```

# Usage
The following code block exemplifies usage of the `DigitalTurbineExchangeAdapter.cs` configuration class.

## IPartnerAdapterConfiguration Properties

```csharp

// AdapterUnityVersion - The partner adapter Unity version, e.g: 5.0.0
Debug.Log($"Adapter Unity Version: {DigitalTurbineExchangeAdapter.AdapterUnityVersion}");

// AdapterNativeVersion - The partner adapter version, e.g: 5.8.2.7.0
Debug.Log($"Adapter Native Version: {DigitalTurbineExchangeAdapter.AdapterNativeVersion}");

// PartnerSDKVersion - The partner SDK version, e.g: 8.2.7
Debug.Log($"Partner SDK Version: {DigitalTurbineExchangeAdapter.PartnerSDKVersion}");

// PartnerIdentifier - The partner ID for internal uses, e.g: fyber
Debug.Log($"Partner Identifier: {DigitalTurbineExchangeAdapter.PartnerIdentifier}");

// PartnerDisplayName - The partner name for external uses, e.g: Digital Turbine Exchange
Debug.Log($"Partner Display Name: {DigitalTurbineExchangeAdapter.PartnerDisplayName}");
```

## Mute Audio
To mute the audio from videos for the Digital Turbine Exchange adapter, the following property has been made available:

```csharp
DigitalTurbineExchangeAdapter.MuteAudio = true;
```

## Verbose Logging
To enable verbose logging for the Digital Turbine Exchange adapter, the following property has been made available:

```csharp
DigitalTurbineExchangeAdapter.VerboseLogging = true;
```
# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - Digital Turbine Exchange Adapter.

#Added
- Support for the following `Digital Turbine Exchange` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-digital-turbine-exchange:5.8.3.+`
    * iOS: `ChartboostMediationAdapterDigitalTurbineExchange ~> 5.8.3.0`
    
- `DigitalTurbineExchangeAdapter.cs` with Configuration Properties for `Digital Turbine Exchange`.
- The following properties have been added in `Digital Turbine ExchangeAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`
    * `bool MuteAudio`
    * `bool VerboseLogging`
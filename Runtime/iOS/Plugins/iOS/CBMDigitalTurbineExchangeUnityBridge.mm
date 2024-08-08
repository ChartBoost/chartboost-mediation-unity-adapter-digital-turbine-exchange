#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <IASDKCore/IASDKCore-Swift.h>
#import <ChartboostMediationAdapterDigitalTurbineExchange/ChartboostMediationAdapterDigitalTurbineExchange-Swift.h>

extern "C" {

    const char * _CBMDigitalTurbineExchangeAdapterAdapterVersion(){
        return toCStringOrNull([DigitalTurbineExchangeAdapterConfiguration adapterVersion]);
    }

    const char * _CBMDigitalTurbineExchangeAdapterPartnerSDKVersion(){
        return toCStringOrNull([DigitalTurbineExchangeAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMDigitalTurbineExchangeAdapterPartnerId(){
        return toCStringOrNull([DigitalTurbineExchangeAdapterConfiguration partnerID]);
    }

    const char * _CBMDigitalTurbineExchangeAdapterPartnerDisplayName(){
        return toCStringOrNull([DigitalTurbineExchangeAdapterConfiguration partnerDisplayName]);
    }

    BOOL _CBMDigitalTurbineExchangeAdapterGetMuteAudio() {
        return [DigitalTurbineExchangeAdapterConfiguration muteAudio];
    }

    void _CBMDigitalTurbineExchangeAdapterSetMuteAudio(BOOL muteAudio){
        [DigitalTurbineExchangeAdapterConfiguration setMuteAudio:muteAudio];
    }

    BOOL _CBMDigitalTurbineExchangeAdapterGetVerboseLogging() {
        return [DigitalTurbineExchangeAdapterConfiguration logLevel] == DTXLogLevelDebug;
    }

    void _CBMDigitalTurbineExchangeAdapterSetVerboseLogging(BOOL verboseLogging){
        if (verboseLogging)
            [DigitalTurbineExchangeAdapterConfiguration setLogLevel:DTXLogLevelDebug];
        else
            [DigitalTurbineExchangeAdapterConfiguration setLogLevel:DTXLogLevelOff];
    }
}

using Chartboost.Constants;
using Chartboost.Mediation.DigitalTurbineExchange.Common;
using UnityEngine;

namespace Chartboost.Mediation.DigitalTurbineExchange.Android
{
    internal sealed class DigitalTurbineExchangeAdapter : IDigitalTurbineExchangeAdapter
    {
        private const string DigitalTurbineExchangeAdapterConfiguration = "com.chartboost.mediation.digitalturbineexchangeadapter.DigitalTurbineExchangeAdapterConfiguration";
        private const string FunctionGetMuteVideo = "getMuteVideo";
        private const string FunctionSetMuteVideo = "setMuteVideo";
        
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            DigitalTurbineExchange.DigitalTurbineExchangeAdapter.Instance = new DigitalTurbineExchangeAdapter();
        }
        
        /// <inheritdoc/>
        public string AdapterNativeVersion
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(DigitalTurbineExchangeAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetAdapterVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerSDKVersion 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(DigitalTurbineExchangeAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerSdkVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerIdentifier
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(DigitalTurbineExchangeAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerId);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerDisplayName 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(DigitalTurbineExchangeAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerDisplayName);
            }
        }
        
        /// <inheritdoc/>
        public bool MuteAudio
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(DigitalTurbineExchangeAdapterConfiguration);
                return adapterConfiguration.Call<bool>(FunctionGetMuteVideo);
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(DigitalTurbineExchangeAdapterConfiguration);
                adapterConfiguration.Call(FunctionSetMuteVideo, value);
            }
        }

        private const int VerboseLogLevel = 2;
        private const int ErrorLogLevel = 6;
        
        /// <inheritdoc/>
        public bool VerboseLogging
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(DigitalTurbineExchangeAdapterConfiguration);
                return adapterConfiguration.Call<int>(SharedAndroidConstants.FunctionGetLogLevel) == VerboseLogLevel;
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(DigitalTurbineExchangeAdapterConfiguration);
                adapterConfiguration.Call(SharedAndroidConstants.FunctionSetLogLevel, value ? VerboseLogLevel : ErrorLogLevel);
            }
        }
    }
}

using Chartboost.Mediation.Adapters;
using Chartboost.Mediation.DigitalTurbineExchange.Common;
using Chartboost.Mediation.DigitalTurbineExchange.Default;

namespace Chartboost.Mediation.DigitalTurbineExchange
{
    /// <inheritdoc cref="IDigitalTurbineExchangeAdapter"/>
    public static class DigitalTurbineExchangeAdapter 
    {
        internal static IDigitalTurbineExchangeAdapter Instance = new DigitalTurbineExchangeDefault();
        
        /// <summary>
        /// The partner adapter Unity version.
        /// </summary>
        public const string AdapterUnityVersion = "5.0.0";
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.AdapterNativeVersion"/>
        public static string AdapterNativeVersion => Instance.AdapterNativeVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerSDKVersion"/>
        public static string PartnerSDKVersion => Instance.PartnerSDKVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerIdentifier"/>
        public static string PartnerIdentifier => Instance.PartnerIdentifier;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerDisplayName"/>
        public static string PartnerDisplayName => Instance.PartnerDisplayName;

        /// <inheritdoc cref="IDigitalTurbineExchangeAdapter.MuteAudio"/>
        public static bool MuteAudio
        {
            get => Instance.MuteAudio;
            set => Instance.MuteAudio = value;
        }

        /// <inheritdoc cref="IDigitalTurbineExchangeAdapter.VerboseLogging"/>
        public static bool VerboseLogging
        {
            get => Instance.VerboseLogging;
            set => Instance.VerboseLogging = value;
        }
    }
}

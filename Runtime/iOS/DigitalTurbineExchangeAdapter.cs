using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.DigitalTurbineExchange.Common;
using UnityEngine;

namespace Chartboost.Mediation.DigitalTurbineExchange.IOS
{
    internal sealed class DigitalTurbineExchangeAdapter : IDigitalTurbineExchangeAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            DigitalTurbineExchange.DigitalTurbineExchangeAdapter.Instance = new DigitalTurbineExchangeAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMDigitalTurbineExchangeAdapterAdapterVersion();
        
        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMDigitalTurbineExchangeAdapterPartnerSDKVersion();
        
        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMDigitalTurbineExchangeAdapterPartnerId();
        
        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMDigitalTurbineExchangeAdapterPartnerDisplayName();
        
        /// <inheritdoc/>
        public bool MuteAudio
        {
            get => _CBMDigitalTurbineExchangeAdapterGetMuteAudio();
            set => _CBMDigitalTurbineExchangeAdapterSetMuteAudio(value);
        }

        /// <inheritdoc/>
        public bool VerboseLogging 
        {
            get => _CBMDigitalTurbineExchangeAdapterGetVerboseLogging();
            set => _CBMDigitalTurbineExchangeAdapterSetVerboseLogging(value);
        }

        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMDigitalTurbineExchangeAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMDigitalTurbineExchangeAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMDigitalTurbineExchangeAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMDigitalTurbineExchangeAdapterPartnerDisplayName();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern bool _CBMDigitalTurbineExchangeAdapterGetMuteAudio();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMDigitalTurbineExchangeAdapterSetMuteAudio(bool muteAudio);
        [DllImport(SharedIOSConstants.DLLImport)] private static extern bool _CBMDigitalTurbineExchangeAdapterGetVerboseLogging();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMDigitalTurbineExchangeAdapterSetVerboseLogging(bool verboseLogging);
    }
}

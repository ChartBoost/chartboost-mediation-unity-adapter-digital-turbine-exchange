using System;
using System.Collections.Generic;
using Chartboost.Mediation.DigitalTurbineExchange.Common;
using Chartboost.Mediation.Data;

namespace Chartboost.Mediation.DigitalTurbineExchange.Default
{
    internal class DigitalTurbineExchangeDefault : IDigitalTurbineExchangeAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => DigitalTurbineExchangeAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => DigitalTurbineExchangeAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "fyber";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "DigitalTurbineExchange";

        /// <inheritdoc/>
        public bool MuteAudio { get; set; }

        /// <inheritdoc/>
        public bool VerboseLogging { get; set; }
    }
}

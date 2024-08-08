using Chartboost.Mediation.Adapters;

namespace Chartboost.Mediation.DigitalTurbineExchange.Common
{
    /// <summary>
    /// The Chartboost Mediation DigitalTurbineExchange adapter.
    /// </summary>
    internal interface IDigitalTurbineExchangeAdapter : IPartnerAdapterConfiguration
    {

        /// <summary>
        /// Flag that can optionally be set to disable audio for the Digital Turbine Exchange SDK.
        /// </summary>
        public bool MuteAudio { get; set; }

        /// <summary>
        /// Enable/disable Digital Turbine Exchange's verbose logging.
        /// </summary>
        public bool VerboseLogging { get; set; }
    }
}

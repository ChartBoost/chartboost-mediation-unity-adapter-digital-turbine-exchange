using Chartboost.Mediation.DigitalTurbineExchange;
using Chartboost.Testing;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class DigitalTurbineExchangeAdapterTests
    {
        [Test]
        public void Identity() => AdapterContract.AssertIdentity("fyber", "DigitalTurbineExchange", DigitalTurbineExchangeAdapter.AdapterUnityVersion,
            DigitalTurbineExchangeAdapter.PartnerIdentifier, DigitalTurbineExchangeAdapter.PartnerDisplayName, DigitalTurbineExchangeAdapter.AdapterNativeVersion, DigitalTurbineExchangeAdapter.PartnerSDKVersion);

        [Test]
        public void MuteAudioKeepsItsValue()
            => AdapterContract.AssertKeeps(() => DigitalTurbineExchangeAdapter.MuteAudio, value => DigitalTurbineExchangeAdapter.MuteAudio = value, true, false);

        [Test]
        public void VerboseLoggingKeepsItsValue()
            => AdapterContract.AssertKeeps(() => DigitalTurbineExchangeAdapter.VerboseLogging, value => DigitalTurbineExchangeAdapter.VerboseLogging = value, true, false);
    }
}

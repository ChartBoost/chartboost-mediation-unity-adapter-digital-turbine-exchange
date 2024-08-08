using Chartboost.Logging;
using Chartboost.Mediation.DigitalTurbineExchange;
using Chartboost.Tests.Runtime;
using NUnit.Framework;

namespace Chartboost.Tests
{
    public class DigitalTurbineExchangeAdapterTests
    {
        [SetUp]
        public void SetUp()
            => LogController.LoggingLevel = LogLevel.Debug;

        [Test]
        public void AdapterNativeVersion()
            => TestUtilities.TestStringGetter(() => DigitalTurbineExchangeAdapter.AdapterNativeVersion);

        [Test]
        public void PartnerSDKVersion()
            => TestUtilities.TestStringGetter(() => DigitalTurbineExchangeAdapter.PartnerSDKVersion);

        [Test]
        public void PartnerIdentifier()
            => TestUtilities.TestStringGetter(() => DigitalTurbineExchangeAdapter.PartnerIdentifier);

        [Test]
        public void PartnerDisplayName()
            => TestUtilities.TestStringGetter(() => DigitalTurbineExchangeAdapter.PartnerDisplayName);

        [Test]
        public void MuteAudio()
            => TestUtilities.TestBooleanAccessor(() => DigitalTurbineExchangeAdapter.MuteAudio, value => DigitalTurbineExchangeAdapter.MuteAudio = value);
        
        [Test]
        public void VerboseLogging()
            => TestUtilities.TestBooleanAccessor(() => DigitalTurbineExchangeAdapter.VerboseLogging, value => DigitalTurbineExchangeAdapter.VerboseLogging = value);
    }
}

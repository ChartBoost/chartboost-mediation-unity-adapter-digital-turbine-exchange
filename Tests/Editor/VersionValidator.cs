using Chartboost.Editor;
using Chartboost.Logging;
using Chartboost.Mediation.DigitalTurbineExchange;
using NUnit.Framework;

namespace Chartboost.Tests.Editor
{
    public class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.digital-turbine-exchange";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.DigitalTurbineExchange";
        
        [SetUp]
        public void SetUp() 
            => LogController.LoggingLevel = LogLevel.Debug;
            
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, DigitalTurbineExchangeAdapter.AdapterUnityVersion);
    }
}

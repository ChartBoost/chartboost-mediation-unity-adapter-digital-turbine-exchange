using System.Runtime.CompilerServices;
using Chartboost.Mediation.DigitalTurbineExchange;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.DigitalTurbineExchangeAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.DigitalTurbineExchangeAssemblyInfoIOS)]

namespace Chartboost.Mediation.DigitalTurbineExchange
{
    internal class AssemblyInfo
    {
        public const string DigitalTurbineExchangeAssemblyInfoAndroid = "Chartboost.Mediation.DigitalTurbineExchange.Android";
        public const string DigitalTurbineExchangeAssemblyInfoIOS = "Chartboost.Mediation.DigitalTurbineExchange.IOS";
    }
}

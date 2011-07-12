using MvcTurbine.ComponentModel;
using MvcTurbine.StructureMap;
using MvcTurbine.Web;

namespace MvcTurbineAreas
{
    public class MvcApplication : TurbineApplication
    {
        public MvcApplication()
        {
            ServiceLocatorManager.SetLocatorProvider(() => new StructureMapServiceLocator());
        }
    }
}
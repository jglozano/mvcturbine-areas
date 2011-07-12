using MvcTurbine.ComponentModel;
using MvcTurbineAreas.BusinessLogic;

namespace MvcTurbineAreas.Registration
{
    public class DefaultRegistration : IServiceRegistration
    {
        public void Register(IServiceLocator locator)
        {
            locator.Register<IExampleDependency, ExampleDependency>();
        }
    }
}
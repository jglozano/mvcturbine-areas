namespace MvcTurbineAreas.BusinessLogic
{
    public class ExampleDependency : IExampleDependency
    {
        public string MyMethod()
        {
            return "Hello World!";
        }
    }

    public interface IExampleDependency
    {
        string MyMethod();
    }
}

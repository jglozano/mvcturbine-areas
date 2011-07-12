using System;
using System.Web.Mvc;
using MvcTurbineAreas.BusinessLogic;

namespace MvcTurbineAreas.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private IExampleDependency _exampleDependency;

        public LoginController(IExampleDependency exampleDependency)
        {
            _exampleDependency = exampleDependency;

            if (_exampleDependency == null)
                throw (new Exception("This shouldn't happen!"));
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            ViewData["Message"] = _exampleDependency.MyMethod();

            return View();
        }

    }
}

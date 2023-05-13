using DesignPattern.ChainOfResponsibility.ChainOfResponsibility;
using DesignPattern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel customerProcessViewModel)
        {
            Employee treasurrer = new Treasurer();
            Employee managerAssistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();

            treasurrer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            treasurrer.ProcessRequest(customerProcessViewModel);
            return View();
        }
    }
}

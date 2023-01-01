using ChainOfResponsibilityDP.ChainOfResponsibility;
using ChainOfResponsibilityDP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResponsibilityDP.Controllers
{
    public class WithdrawRequest : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(WithdrawViewModel req)
        {
            Employee treasurer = new Treasurer();
            Employee operationsDirector = new OperationsDirector();
            Employee branchManager = new BranchManager();
            Employee regionalManager = new RegionalManager();

            treasurer.SetNextApprover(operationsDirector);
            operationsDirector.SetNextApprover(branchManager);
            branchManager.SetNextApprover(regionalManager);

            treasurer.ProcessRequest(req);

            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using PracticeCoreCDPs.Areas.Builder.Core;

namespace PracticeCoreCDPs.Areas.Builder.Controllers
{
    [Area("Builder")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Build(string usagetype)
        {
            IComputerBuilder builder = null;
            switch (usagetype)
            {
                case "home":
                    builder = new HomeComputerBuilder();
                    break;
                case "office":
                    builder = new OfficeComputerBuilder();
                    break;
                case "development":
                    builder = new DevelopmentComputerBuilder();
                    break;
            }

            ComputerAssembler assembler = new ComputerAssembler(builder);
            Computer computer = assembler.AssembleComputer();
            return View("Success", computer);
        }
    }
}

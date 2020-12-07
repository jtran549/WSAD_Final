using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassSchedule.Models;
using FinalProject.Models;
using FinalProject.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class FederationsController : Controller
    {
        private Repository<Federation> federations { get; set; }
        public FederationsController(FederationContext ctx) => federations = new Repository<Federation>(ctx);
        public IActionResult Index()
        {
            return View();
        }
    }
}

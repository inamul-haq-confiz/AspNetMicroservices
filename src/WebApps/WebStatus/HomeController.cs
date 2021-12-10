using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStatus
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("/healthchecks-ui");
        }
    }
}

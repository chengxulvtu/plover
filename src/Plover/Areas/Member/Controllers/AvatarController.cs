using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Plover.Areas.Member.Controllers
{
    [Area(Constant.AREA_NAME_MEMBER)]
    public class AvatarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Upload()
        {

            return View();
        }
    }
}

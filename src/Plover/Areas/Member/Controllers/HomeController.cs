using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Plover.Areas.Member.Controllers
{
    [Area(Constant.AREA_NAME_MEMBER)]
    [Route(Constant.ROUTE_NAME_MEMBER)]
    public class HomeController : Controller
    {
        /// <summary>
        /// 会员主页
        /// </summary>
        /// <param name="userName">用户名</param>
        [HttpGet("{userName}")]
        public IActionResult Index(string userName)
        {
            ViewBag.UserName = userName;
            return View();
        }
    }
}

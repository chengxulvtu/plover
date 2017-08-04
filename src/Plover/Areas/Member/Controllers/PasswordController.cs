using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Plover.Areas.Member.Controllers
{
    [Area(Constant.AREA_NAME_MEMBER)]
    public class PasswordController : Controller
    {
        /// <summary>
        /// 忘记密码
        /// </summary>
        public IActionResult Forget()
        {
            return View();
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        public IActionResult Reset()
        {

            return View();
        }
    }
}

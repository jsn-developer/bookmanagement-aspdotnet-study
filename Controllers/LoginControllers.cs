using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookManagementApp.Models;
using Microsoft.AspNetCore.Http;

namespace BookManagementApp.Controllers
{
    /// <summary>
    /// ログイン処理に関するコントローラー
    /// </summary>
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction(nameof(Main));
        }

        public IActionResult Main()
        {
            return View();
        }
    }
}

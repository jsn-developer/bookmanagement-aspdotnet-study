using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookManagementApp.Models;
using Microsoft.AspNetCore.Http;

namespace BookManagementApp.Controllers
{
    /// <summary>
    /// 書籍管理に関する処理を行うコントローラー
    /// </summary>
    public class BookManagementController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction(nameof(List));
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }

}

﻿using Microsoft.AspNetCore.Mvc;

namespace Progetto_UI.Web.Features.Home
{
    public partial class HomeController : Controller
    {
        [HttpGet]
        public virtual IActionResult Index()
        {
            var model = new HomeViewModel();
            return View("Home", model);
        }

        [HttpGet]
        public virtual IActionResult Login()
        {
            RemoveRememberMeCookie();
            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        public virtual IActionResult Inserimento()
        {
            return RedirectToAction("Index", "Inserimento");
        }

        [HttpGet]
        public virtual IActionResult Consegna()
        {
            return RedirectToAction("Index", "Consegna");
        }

        [HttpGet]
        public virtual IActionResult Spostamento()
        {
            return RedirectToAction("Index", "Spostamento");
        }

        [HttpGet]
        public virtual IActionResult Ricerca()
        {
            return RedirectToAction("Index", "Ricerca");
        }

        private void RemoveRememberMeCookie()
        {
            if (Request.Cookies.ContainsKey(".AspNetCore.Cookies"))
            {
                Response.Cookies.Delete(".AspNetCore.Cookies");
            }
        }
    }
}
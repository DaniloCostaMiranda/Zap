﻿using Microsoft.AspNetCore.Mvc;

namespace Zap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction(nameof(Login));
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult Conversacao()
        {
            return View();
        }
    }
}

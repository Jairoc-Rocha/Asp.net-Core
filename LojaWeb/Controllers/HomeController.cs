using LojaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LojaWeb.Controllers
{
    public class HomeController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Title"] = "Políticas de Privacidade";
            ViewBag.Nome = "Carlos";
            return View();
        }

        [HttpPost]
        public IActionResult Privacy(string Id, string Nome)
        {
            return View();
        }

        [Route("/Mensagem/Saudacao/")]
        public IActionResult Saudacao()
        {
            return Content($"Olá usuário");
        }

        //[Route("/Mensagem/Saudacao/")]
        public IActionResult Saudacao(int id)
        {
            return Content($"Olá usuário {id}");
        }

    }
}

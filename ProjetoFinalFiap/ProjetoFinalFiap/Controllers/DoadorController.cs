using Microsoft.AspNetCore.Mvc;
using ProjetoFinalFiap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinalFiap.Controllers
{
    public class DoadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MenuDoador()
        {
            return View();
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

   
    }
}

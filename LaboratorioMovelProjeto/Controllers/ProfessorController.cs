using LaboratorioMovelProjeto.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioMovelProjeto.Controllers
{
    public class ProfessorController : Controller
    {

        //Abrir tela Professores
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        //Abrir Tela para inserir novo professor
        [HttpGet]
        public IActionResult NovoProfessor()
        {
            return View();
        }


        //Capturar dados do novo professor
        [HttpPost]
        public IActionResult NovoProfessor(ProfessorModel professorModel)
        {
            return View("Sucesso");
        }

        [HttpGet]
        public IActionResult Editar()
        {
            return View("EditarProfessor");
        }


        [HttpGet]
        public IActionResult Help()
        {
            return View();
        }

        

        public IActionResult Conteudo()
        {
            return Content("Retornando o conteúdo em String");
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}

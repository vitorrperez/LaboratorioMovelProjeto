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
            ProfessorModel professorModel = new ProfessorModel();

            var listaProfessor = new List<ProfessorModel>();
            listaProfessor.Add(new ProfessorModel
            {
                ProfessorId = 1,
                Nome = "Vitor",
                Email = "vitorrperez@gmail.com",
                DataNascimento = DateTime.Now,
                Observacao = "Teste"
            });

            listaProfessor.Add(new ProfessorModel
            {
                ProfessorId = 2,
                Nome = "Samue",
                Email = "samuel@gmail.com",
                DataNascimento = DateTime.Now,
                Observacao = "SAMUCA DA GALERA"
            });

            listaProfessor.Add(new ProfessorModel 
            {
                ProfessorId = 3,
                Nome = "Marco",
                Email = "marco@gmail.com",
                DataNascimento = DateTime.Now,
                Observacao = "MARCÃO QUERIDO NOS CLS"
            });

            listaProfessor.Add(new ProfessorModel 
            {
                ProfessorId = 4,
                Nome = "Marcelo",
                Email = "marcelo@gmail.com",
                DataNascimento = DateTime.Now,
                Observacao = "MARCELO QUE NGM CONHECE"
            });


            return View(listaProfessor);
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

        //Exibir dados de edição
        [HttpGet]
        public IActionResult Editar(int id)
        {
            ProfessorModel professorModel = new ProfessorModel();

            if (id == 1)
            {
                professorModel = new ProfessorModel
                {
                    ProfessorId = 1,
                    Nome = "Vitor",
                    Email = "vitorperez@gmail.com",
                    DataNascimento = DateTime.Now,
                    Observacao = "EAE VITÃO",
                };
            }
            else if (id == 2)
            {
                professorModel = new ProfessorModel
                {
                    ProfessorId = 2,
                    Nome = "Fernando",
                    Email = "fernando@gmail.com",
                    DataNascimento = DateTime.Now,
                    Observacao = "EAE FERNANDO",
                };
            }
            else if (id == 3)
            {
                professorModel = new ProfessorModel
                {
                    ProfessorId = 3,
                    Nome = "Paulo",
                    Email = "paulo@gmail.com",
                    DataNascimento = DateTime.Now,
                    Observacao = "EAE PAULO",
                };

            }
            else if (id == 4)
            {
                professorModel = new ProfessorModel
                {
                    ProfessorId = 2,
                    Nome = "Marcelo",
                    Email = "marcelo@gmail.com",
                    DataNascimento = DateTime.Now,
                    Observacao = "EAE MARCELO",
                };
            }


            return View(professorModel);
        }


        [HttpGet]
        public IActionResult Detalhe(int id)
        {
            ProfessorModel professorModel = new ProfessorModel();

            if (id == 1)
            {
                professorModel = new ProfessorModel
                {
                    ProfessorId = 1,
                    Nome = "Vitor",
                    Email = "vitorperez@gmail.com",
                    DataNascimento = DateTime.Now,
                    Observacao = "EAE VITÃO",
                };
            }
            else if (id == 2)
            {
                professorModel = new ProfessorModel
                {
                    ProfessorId = 2,
                    Nome = "Fernando",
                    Email = "fernando@gmail.com",
                    DataNascimento = DateTime.Now,
                    Observacao = "EAE FERNANDO",
                };
            }
            else if (id == 3)
            {
                professorModel = new ProfessorModel
                {
                    ProfessorId = 3,
                    Nome = "Paulo",
                    Email = "paulo@gmail.com",
                    DataNascimento = DateTime.Now,
                    Observacao = "EAE PAULO",
                };

            }
            else if (id == 4)
            {
                professorModel = new ProfessorModel
                {
                    ProfessorId = 2,
                    Nome = "Marcelo",
                    Email = "marcelo@gmail.com",
                    DataNascimento = DateTime.Now,
                    Observacao = "EAE MARCELO",
                };
            }


            return View(professorModel);
        }


    }
}

﻿using QIntroducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QIntroducao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "João Paulo",
                Tipo = "Administrador"
            };

            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Tipo"] = pessoa.Tipo;

            //ViewBag.Id = pessoa.PessoaId;
            //ViewBag.Nome = pessoa.Nome;
            //ViewBag.Tipo = pessoa.Tipo;



            return View(pessoa);
        }

        public ActionResult Contatos()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Lista(int PessoaId, string Nome, string Tipo)
        //{
        //    ViewData["PessoaId"] = PessoaId;
        //    ViewData["Nome"] = Nome;
        //    ViewData["Tipo"] = Tipo;

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Lista(FormCollection form)
        //{
        //    ViewData["PessoaId"] = form["PessoaId"];
        //    ViewData["Nome"] = form["Nome"];
        //    ViewData["Tipo"] = form["Tipo"];

        //    return View();
        //}

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Tipo"] = pessoa.Tipo;

            return View(pessoa);
        }
    }
}
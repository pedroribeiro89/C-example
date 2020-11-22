using Aula2FSNET.Business;
using Aula2FSNET.Modelo;
using Aula2FSNET.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Aula2FSNET.Controllers
{
    public class DiscoController : Controller
    {
        public DiscoController()
        {
        }

        //LISTA
        public IActionResult DiscoList([FromServices] DiscoBusiness discoBusiness)
        {
            IEnumerable<Disco> discos = discoBusiness.listDiscos();

            DiscosViewModel vm = new DiscosViewModel();
            vm.discos = discos;

            return View(vm);
        }

        //DETAIL
        public IActionResult DetailDisco(string id, [FromServices] DiscoBusiness discoBusiness)
        {
            Disco disco = discoBusiness.GetDisco(id);

            DiscosViewModel vm = new DiscosViewModel();
            vm.disco = disco;

            return View(vm);
        }

        //CREATE
        [HttpGet]
        public IActionResult CreateDisco()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Disco disco, [FromServices] DiscoBusiness discoBusiness)
        {
            discoBusiness.CreateDisco(disco);
            return RedirectToAction("DiscoList");
        }

        //EDIT
        [HttpGet]
        public IActionResult EditDisco(string id, [FromServices] DiscoBusiness discoBusiness)
        {
            Disco disco = discoBusiness.GetDisco(id);

            DiscosViewModel vm = new DiscosViewModel();
            vm.disco = disco;

            return View(vm);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(Disco disco, [FromServices] DiscoBusiness discoBusiness)
        {
            discoBusiness.EditDisco(disco);
            return RedirectToAction("DiscoList");
        }

        //DELETE
        [Authorize]
        [HttpGet]
        public IActionResult DeleteDisco(string id, [FromServices] DiscoBusiness discoBusiness)
        {
            discoBusiness.DeleteDisco(id);
            return RedirectToAction("DiscoList");
        }
    }
}

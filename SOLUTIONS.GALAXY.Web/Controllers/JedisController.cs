using Microsoft.AspNetCore.Mvc;
using SOLUTIONS.GALAXY.Application.Interfaces;
using SOLUTIONS.GALAXY.Domain.Entities;
using SOLUTIONS.GALAXY.Web.Models;
using System;

namespace SOLUTIONS.GALAXY.Web.Controllers
{
    public class JedisController : Controller
    {
        private readonly IJediApp jediApp;
        public JedisController(IJediApp _jediApp)
        {
            jediApp = _jediApp;
        }

        public IActionResult Index()
        {
            var jediViewModel = new JediViewModel
            {
                Jedis = jediApp.GetAll()
            };
            return View(jediViewModel);
        }
        [HttpPut]
        public string Edit(int id)
        {
            return jediApp.ChangeStatus(id);
        }
        [HttpGet]
        public PartialViewResult GetAll()
        {
            var jediViewModel = new JediViewModel
            {
                Jedis = jediApp.GetAll()
            };
            return PartialView("_Jedis", jediViewModel);
        }
        [HttpGet]
        public IActionResult Refresh()
        {
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult GetByGrade(string grade)
        {
            var jediViewModel = new JediViewModel
            {
                Jedis = jediApp.GetByGrade(grade)
            };
            return PartialView("_Jedis", jediViewModel);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Jedi jedi)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    jediApp.Creat(jedi);
                    return RedirectToAction("Index");
                }
                return View(jedi);
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
                return View(jedi);
            }
        }
        [HttpGet]
        public ActionResult _Edit(int id)
        {
            var jedi = jediApp.GetById(id);
            return PartialView("_Edit",jedi);
        }

        [HttpPost]
        public ActionResult Edit(Jedi jedi)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = jediApp.Edit(jedi);
                    ViewData["Error"] = result;
                    return PartialView("_Edit", jedi);
                }
                return PartialView("_Edit",jedi);
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
                return PartialView("_Edit", jedi);
            }
        }
    }
}
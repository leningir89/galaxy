using Microsoft.AspNetCore.Mvc;
using SOLUTIONS.GALAXY.Application.Interfaces;
using SOLUTIONS.GALAXY.Domain.Entities;
using System;
using SOLUTIONS.GALAXY.Infraestructure.Domain.Entities;

namespace SOLUTIONS.GALAXY.Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderHologramsApp orderHologramsApp;
        public OrdersController(IOrderHologramsApp _orderHologramsApp)
        {
            orderHologramsApp = _orderHologramsApp;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Create(OrdersHolograms order)
        {
            try
            {
                var result = orderHologramsApp.CreateOrder(order);
                return Json(result);
            }
            catch (Exception ex)
            {
                return Json(new Message
                {
                    IsError = true,
                    Description = ex.Message
                });
            }
        }
    }
}
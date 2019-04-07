using SOLUTIONS.GALAXY.Application.Interfaces;
using SOLUTIONS.GALAXY.Application.Resources;
using SOLUTIONS.GALAXY.Domain.Entities;
using SOLUTIONS.GALAXY.Domain.Interfaces.Services;
using SOLUTIONS.GALAXY.Infraestructure.Domain.Entities;
using System.Collections.Generic;

namespace SOLUTIONS.GALAXY.Application.App
{
    public class OrderHologramsApp : IOrderHologramsApp
    {
        private readonly IOrderHologramsService orderHologramsService;

        public OrderHologramsApp(IOrderHologramsService _orderHologramsService)
        {
            orderHologramsService = _orderHologramsService;
        }

        public Message CreateOrder(OrdersHolograms order)
        {
            var mensagge =  new Message
            {
                IsError = true,
                Description = Messages.OrderExist
            };
            if(orderHologramsService.GetByIds(order))
            {
                return mensagge;
            }
            
            var result = orderHologramsService.CreateOrder(order);
            if (result)
            {
                mensagge.IsError = false;
                mensagge.Description = Messages.CreateOrder;
            }
            return mensagge;
        }

        public IEnumerable<HologramList> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}

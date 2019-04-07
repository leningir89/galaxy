using SOLUTIONS.GALAXY.Domain.Entities;
using SOLUTIONS.GALAXY.Domain.Interfaces.Repositories;
using SOLUTIONS.GALAXY.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLUTIONS.GALAXY.Services.Services
{
    public class OrderHologramsService : IOrderHologramsService
    {
        private readonly IOrdersHologramsRepository ordersHologramsRepository;
        public OrderHologramsService(IOrdersHologramsRepository _ordersHologramsRepository)
        {
            ordersHologramsRepository = _ordersHologramsRepository;
        }

        public bool CreateOrder(OrdersHolograms order)
        {
            return ordersHologramsRepository.CreateOrder(order);
        }

        public IList<HologramList> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<OrdersHolograms> GetByHologramdId(int hologramId)
        {
            return ordersHologramsRepository.GetByHologramdId(hologramId);
        }

        public bool GetByIds(OrdersHolograms order)
        {
            return ordersHologramsRepository.GetByIds(order) != null;
        }
    }
}

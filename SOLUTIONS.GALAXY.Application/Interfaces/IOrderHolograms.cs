using SOLUTIONS.GALAXY.Domain.Entities;
using SOLUTIONS.GALAXY.Infraestructure.Domain.Entities;
using System.Collections.Generic;

namespace SOLUTIONS.GALAXY.Application.Interfaces
{
    public interface IOrderHologramsApp
    {
        IEnumerable<HologramList> GetAll();
        Message CreateOrder(OrdersHolograms order);
    }
}

using SOLUTIONS.GALAXY.Domain.Entities;
using System.Collections.Generic;

namespace SOLUTIONS.GALAXY.Domain.Interfaces.Repositories
{
    public interface IOrdersHologramsRepository
    {
        bool CreateOrder(OrdersHolograms order);
        IList<OrdersHolograms> GetAll();
        IList<OrdersHolograms> GetByHologramdId(int hologramId);
        OrdersHolograms GetByIds(OrdersHolograms order);
    }
}

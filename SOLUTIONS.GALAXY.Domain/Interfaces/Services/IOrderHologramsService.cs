using SOLUTIONS.GALAXY.Domain.Entities;
using System.Collections.Generic;

namespace SOLUTIONS.GALAXY.Domain.Interfaces.Services
{
    public interface IOrderHologramsService
    {
        bool CreateOrder(OrdersHolograms order);
        IList<HologramList> GetAll();
        IList<OrdersHolograms> GetByHologramdId(int hologramId);
        bool GetByIds(OrdersHolograms order);

    }
}

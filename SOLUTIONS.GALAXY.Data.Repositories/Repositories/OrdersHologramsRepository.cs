using Dapper;
using SOLUTIONS.GALAXY.Data.Repositories.Resources;
using SOLUTIONS.GALAXY.Domain.Entities;
using SOLUTIONS.GALAXY.Domain.Interfaces.Repositories;
using SOLUTIONS.GALAXY.Infraestructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLUTIONS.GALAXY.Data.Repositories.Repositories
{
    public class OrdersHologramsRepository : RepositoryBase, IOrdersHologramsRepository
    {
        public OrdersHologramsRepository(IUnitOfWork _unitOfWork) : base(_unitOfWork)
        {
        }

        public bool CreateOrder(OrdersHolograms order)
        {
            try
            {
                Connection.Execute(Scritps.InsertOrder, new { order.JediId, order.HologramId}, Transaction);
                UnitOfWork.CommitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public IList<OrdersHolograms> GetAll()
        {
            return Connection.Query<OrdersHolograms>(Scritps.GetOrderHolograms, transaction: Transaction).ToList();
        }

        public IList<OrdersHolograms> GetByHologramdId(int hologramId)
        {
            string sql = string.Format(Scritps.GetOrderHolograms, hologramId);
            return Connection.Query<OrdersHolograms>(sql, transaction: Transaction).ToList();
        }

        public OrdersHolograms GetByIds(OrdersHolograms order)
        {
            string sql = string.Format(Scritps.GetOrderHologramsByIds, order.HologramId, order.JediId);
            return Connection.QueryFirstOrDefault<OrdersHolograms>(sql, transaction: Transaction);
        }
    }
}

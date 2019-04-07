using Dapper;
using SOLUTIONS.GALAXY.Domain.Entities;
using SOLUTIONS.GALAXY.Domain.Interfaces.Repositories;
using SOLUTIONS.GALAXY.Infraestructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLUTIONS.GALAXY.Data.Repositories.Repositories
{
    public class HologramRepository : RepositoryBase, IHologramRepository
    {
        public HologramRepository(IUnitOfWork _unitOfWork) : base(_unitOfWork)
        {
        }

        public IList<Hologram> GetAll()
        {
            return Connection.Query<Hologram>("SELECT * FROM Hologram", transaction: Transaction).ToList();
        }

        public IList<Hologram> GetAllByActive()
        {
            return Connection.Query<Hologram>("SELECT * FROM Hologram WHERE Status = 1",transaction: Transaction).ToList();
        }

        public Hologram GetById(int id)
        {
            return Connection.QueryFirst<Hologram>(
                   string.Format("SELECT * FROM Hologram Where Id = {0}", id),
              transaction: Transaction);
        }
    }
}

using Dapper;
using SOLUTIONS.GALAXY.Data.Repositories.Resources;
using SOLUTIONS.GALAXY.Domain.Entities;
using SOLUTIONS.GALAXY.Domain.Interfaces.Repositories;
using SOLUTIONS.GALAXY.Infraestructure.Repository.Base;
using System.Collections.Generic;
using System.Linq;

namespace SOLUTIONS.GALAXY.Data.Repositories.Repositories
{
    public class JediRepository : RepositoryBase, IJediRepository
    {
        public JediRepository(IUnitOfWork _unitOfWork) : base(_unitOfWork)
        {
        }

        public bool Add(Jedi jedi)
        {
            try
            {
                Connection.Execute(Scritps.InsertJedi, new {jedi.Name, jedi.Age, LightsaberColor = jedi.LightsaberColorId,Grade = jedi.GradeId}, Transaction);
                UnitOfWork.CommitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool ChangeStatus(int id, bool status)
        {
            string sql = string.Format(Scritps.ChangeStatusJedi,id);
            try
            {
                Connection.Execute(sql, new { status }, Transaction);
                UnitOfWork.CommitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Edit(Jedi jedi)
        {
            string sql = string.Format(Scritps.UpdateJedi, jedi.Id);
            try
            {
                Connection.Execute(sql, new { jedi.Name, jedi.Age, LightsaberColor = jedi.LightsaberColorId, Grade = jedi.GradeId }, Transaction);
                UnitOfWork.CommitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public IList<Jedi> GetAll()
        {
            return Connection.Query<Jedi>(
                 "SELECT * FROM Jedi",
             transaction: Transaction).ToList();
        }

        public IList<Jedi> GetByFilterGrade(short grade)
        {
            return Connection.Query<Jedi>(
                 string.Format("SELECT * FROM Jedi Where Grade = {0}", grade),
           transaction: Transaction).ToList();
        }

        public Jedi GetById(int id)
        {
            return Connection.QueryFirst<Jedi>(
                string.Format("SELECT * FROM Jedi Where Id = {0}", id),
           transaction: Transaction);
        }
    }
}

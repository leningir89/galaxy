using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SOLUTIONS.GALAXY.Infraestructure.Repository.Base
{
    public abstract class RepositoryBase
    {
        protected IUnitOfWork UnitOfWork { get; set; }
        protected IDbTransaction Transaction { get { return UnitOfWork.GetTransaction(); } }
        protected IDbConnection Connection { get { return UnitOfWork.GetConnection(); } }
        protected RepositoryBase(IUnitOfWork _unitOfWork)
        {
            UnitOfWork = _unitOfWork;
        }
    }
}

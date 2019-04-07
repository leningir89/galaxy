using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SOLUTIONS.GALAXY.Infraestructure.Repository.Base
{
    public interface IUnitOfWork
    {
        SqlConnection GetConnection();
        SqlTransaction GetTransaction();
        void CommitChanges();
    }
}

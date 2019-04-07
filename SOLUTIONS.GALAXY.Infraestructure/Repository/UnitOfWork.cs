using SOLUTIONS.GALAXY.Infraestructure.Repository.Base;
using System.Data.SqlClient;
using SOLUTIONS.GALAXY.Infraestructure.Domain.Entities;

namespace SOLUTIONS.GALAXY.Infraestructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public SqlConnection GetConnection()
        {
            if (connection != null)
            {
                return connection;
            }

            connection = new SqlConnection(Configurations.ConnectionString);
            connection.Open();
            transaction = connection.BeginTransaction();
            return connection;
        }

        public SqlTransaction GetTransaction()
        {
            return this.transaction;
        }

        public void CommitChanges()
        {
            try
            {
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
            }
        }
    }
}

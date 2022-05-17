using Npgsql;
using Simple_bank.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Simple_bank.Data.Repositories
{
    public class TransferRepository : ITransferReposity
    {
        private PostgreSQLConfiguration _connectionString;
        public TransferRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }
        public Task<bool> DeleteTransfer(Transfer transfer)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transfer>> GetAllTransfers()
        {
            throw new NotImplementedException();
        }

        public Task<Transfer> GetTransferDetails(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertTransfer(Transfer transfer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTransfer(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}

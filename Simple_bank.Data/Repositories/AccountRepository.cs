using Dapper;
using Npgsql;
using Simple_bank.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Simple_bank.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private PostgreSQLConfiguration _connectionString;
        public AccountRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString); 
        }

        public async Task<bool> DeleteAccount(Account account)
        {
            var db = dbConnection();

            var sql = @"
                        DELETE
                        FROM public.accounts
                        ";
            var result = await db.ExecuteAsync(sql, new { Id = account.Id });

            return result > 0;
        }

        public async Task<Account> GetAccountDetails(int id)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT id,currency,owner,balance,created_at
                        FROM public.accounts
                        WHERE id = @Id;
                        ";
            return await db.QueryFirstOrDefaultAsync<Account>(sql, new { Id = id });
        }

        public async Task<IEnumerable<Account>> GetAllAccounts()
        {
            var db = dbConnection();

            var sql = @"
                        SELECT id,currency,owner,balance,created_at
                        FROM public.accounts
                        "  ;
            return await db.QueryAsync<Account>(sql, new { });    
        }

        public async Task<bool> InsertAccount(Account account)
        {
            var db = dbConnection();

            var sql = @"
                        INSERT INTO public.accounts(owner,balance,currency)
                        VALUES(@Currency,@Owner,@Balance)
                        ";
            var result = await db.ExecuteAsync(sql, new { account.Owner, account.Balance, account.Currency });
            return result > 0;
        }

        public async Task<bool> UpdateAccount(Account account)
        {
            var db = dbConnection();

            var sql = @"
                        UPTDATE public.accounts
                        SET owner = @Owner,
                            currency = @Currency,
                            balance = @Balance,
                        WHERE id = @Id;
                        ";
            var result = await db.ExecuteAsync(sql, new { account.Owner, account.Balance, account.Currency,account.Id });

            return result > 0;
        }
    }
}

using Simple_bank.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Simple_bank.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public Task<bool> DeleteAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public Task<Account> GetAccountDetails(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Account>> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}

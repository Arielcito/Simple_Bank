using Microsoft.AspNetCore.Mvc;
using Simple_bank.Data.Repositories;
using Simple_bank.Model;
using System.Threading.Tasks;

namespace Simple_bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        [HttpGet]
        public async Task<IAccountRepository> GetAllAccounts()
        {
            return (IAccountRepository)Ok(await _accountRepository.GetAllAccounts());
        }
        [HttpGet("{id}")]
        public async Task<IAccountRepository> GetAccountDetails(int id)
        {
            return (IAccountRepository)Ok(await _accountRepository.GetAccountDetails(id));
        }
        [HttpPost()]
        public async Task<IAccountRepository> CreateAccount([FromBody]Account account)
        {
            if (account == null)
                return (IAccountRepository)BadRequest();
            if (!ModelState.IsValid) return (IAccountRepository)BadRequest();
            var created = await _accountRepository.InsertAccount(account);
            return (IAccountRepository)Created("created",created);
        }
        [HttpPut()]
        public async Task<IAccountRepository> UpdateAccount([FromBody] Account account)
        {
            if (account == null)
                return (IAccountRepository)BadRequest();
            if (!ModelState.IsValid) return (IAccountRepository)BadRequest();
            var created = await _accountRepository.UpdateAccount(account);
            return (IAccountRepository)NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IAccountRepository> DeleteAccount(int id)
        {
            await _accountRepository.DeleteAccount(new Account { Id = id });
            return (IAccountRepository)NoContent();
        }
    }
}

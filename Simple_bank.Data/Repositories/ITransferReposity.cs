using Simple_bank.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Simple_bank.Data.Repositories
{
    public interface ITransferReposity
    {
        Task<IEnumerable<Transfer>> GetAllTransfers();
        Task<Transfer> GetTransferDetails(int Id);
        Task<bool> InsertTransfer(Transfer transfer);
        Task<bool> UpdateTransfer(Transfer transfer);
        Task<bool> DeleteTransfer(Transfer transfer);
    }
}

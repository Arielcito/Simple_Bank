using Simple_bank.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Simple_bank.Data.Repositories
{
    public interface IEntryRepository
    {
        Task<IEnumerable<Entry>> GetAllEntries();
        Task<Entry> GetEntryDetails(int Id);
        Task<bool> InsertEntry(Entry entry);
        Task<bool> UpdateEntry(Entry entry);
        Task<bool> DeleteEntry(Entry entry);
    }
}

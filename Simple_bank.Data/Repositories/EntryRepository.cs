using Simple_bank.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Simple_bank.Data.Repositories
{
    public class EntryRepository : IEntryRepository
    {
        public Task<bool> DeleteEntry(Entry entry)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entry>> GetAllEntries()
        {
            throw new NotImplementedException();
        }

        public Task<Entry> GetEntryDetails(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertEntry(Entry entry)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEntry(Entry entry)
        {
            throw new NotImplementedException();
        }
    }
}

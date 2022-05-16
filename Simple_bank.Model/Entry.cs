using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_bank.Model
{
    public class Entry
    {
        public int Id { get; set; }
        public int Account_id { get; set; }
        public int amount { get; set; }
        public DateTime Created_at { get; set; }
    }
}

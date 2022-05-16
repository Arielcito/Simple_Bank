using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_bank.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public int Balance  { get; set; }
        public string Currency { get; set; }
        public DateTime Created_at { get; set; }

    }
}

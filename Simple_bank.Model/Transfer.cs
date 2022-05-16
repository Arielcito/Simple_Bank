using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_bank.Model
{
    public class Transfer
    {
        public int Id { get; set; }
        public int From_account_id { get; set; }
        public int To_account_id { get; set; }
        public int Amount { get; set; }
        public DateTime Created_at { get; set; }

    }
}

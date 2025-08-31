using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_account_management_app
{
    public class BankAccount
    {
        public string Owner { get; set; };
        public Guid accountNumber { get; set; };
        public decimal Balance { get; set; };
    }
}

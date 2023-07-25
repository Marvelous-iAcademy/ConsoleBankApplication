using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankProject.Entities
{
    public class Transactions 
    {
        public string TransactionDescription { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionSource { get; set; }
        public string TransactionDestination { get; set; }
    }
}

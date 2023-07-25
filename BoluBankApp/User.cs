using ConsoleBankProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoluBankApp
{
    public class User
    {
        public List<IAccount> UserAccounts { get; set; }
    }
}

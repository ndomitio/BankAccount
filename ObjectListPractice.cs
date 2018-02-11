using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class ObjectListPractice
    {
        //fields invisible

        //properties
        public List<Client> AllClients { get; set; }
        public List<CheckingAccount> CheckingAccounts { get; set; }
        public List<SavingsAccount> SavingsAccounts { get; set; }

        //****having a list of objects as a property is something you want to be aware of going forward for weekend project

        //methods

        public List<bool> DisplayClientNames()
        {
            List<bool> clientHasSavings = new List<bool>();
            foreach (Client client in AllClients)
            {
                clientHasSavings.Add(client.HasSavingsAccount);

            }
            return clientHasSavings;
        }
      

    }
}

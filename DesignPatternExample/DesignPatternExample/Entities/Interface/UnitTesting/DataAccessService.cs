using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Interface.UnitTesting
{
    class DataAccessService : IDataAccessService
    {
        public bool IsUserValid(string userName, string password)
        {
            //logging
            //connect to database and check if the user is valid
            return userName == "Dhilip";
        }

        public bool IsBalanceAvailable(int accountNumber, int amount)
        {
            //logging
            //connect to database and get the balance
            return true;
        }
    }
}

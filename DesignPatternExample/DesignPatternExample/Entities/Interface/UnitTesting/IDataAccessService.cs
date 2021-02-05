using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Interface.UnitTesting
{
    public interface IDataAccessService
    {
        bool IsUserValid(string userName, string password);
        bool IsBalanceAvailable(int accountNumber, int amount);
    }
}

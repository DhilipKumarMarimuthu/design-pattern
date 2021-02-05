using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Interface.UnitTesting
{
    //class BalanceCheckerService // Concrete class implementation
    public class BalanceCheckerService : IBalanceCheckService
    {
        private IDataAccessService _dataAccessService;
        public BalanceCheckerService(IDataAccessService dataAccessService)
        {
            _dataAccessService = dataAccessService;
        }

        public bool IsBalanceAvailable(int accountNumber, int amount)
        {
            if (amount == 0)
                throw new ArgumentNullException("withdrawal amount cannot be null");
            return _dataAccessService.IsBalanceAvailable(accountNumber, amount);
        }
    }
}

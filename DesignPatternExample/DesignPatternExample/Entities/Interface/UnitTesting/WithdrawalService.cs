using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Interface.UnitTesting
{
    public class WithdrawalService
    {
        //private AuthenticationService authenticationService;// Concrete class implementation
        //private BalanceCheckerService balanceCheckerService;// Concrete class implementation
        private IAuthenticationService _authenticationService;
        private IBalanceCheckService _balanceCheckeService;


        public WithdrawalService(IAuthenticationService authenticationService, IBalanceCheckService balanceCheckService)
        {
            _authenticationService = authenticationService;
            _balanceCheckeService = balanceCheckService;
            //authenticationService = new AuthenticationService();// Concrete class implementation
            //balanceCheckerService = new BalanceCheckerService();// Concrete class implementation
        }

        //Problem here - This method has code smell. It's not testable. It has direct dependencies of authentication and balance check services
        //               The new key words are most horrible things while writing unit test code. [refer constructor here ]
        public bool IsEligibleToWithDrawal(string userName, string password, int accountNumber, int amount)
        {
            bool isAuthenticated = _authenticationService.Authenticate(userName, password);
            if (!isAuthenticated)
                throw new Exception("The user is not valid");
            return _balanceCheckeService.IsBalanceAvailable(accountNumber, amount);
        }
    }
}

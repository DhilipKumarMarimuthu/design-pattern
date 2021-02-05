using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Interface.UnitTesting
{
    //class AuthenticationService // Concrete class implementation
    public class AuthenticationService : IAuthenticationService
    {
        private IDataAccessService _dataAccessService;
        public AuthenticationService(IDataAccessService dataAccessService)
        {
            _dataAccessService = dataAccessService;
        }

        public bool Authenticate(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                throw new ArgumentNullException("username or password is invalid");
            return _dataAccessService.IsUserValid(userName, password);
        }
    }
}

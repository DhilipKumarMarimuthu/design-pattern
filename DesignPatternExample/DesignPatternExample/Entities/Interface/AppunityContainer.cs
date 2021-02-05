using DesignPatternExample.Entities.Interface.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DesignPatternExample.Entities.Interface
{
    class AppunityContainer
    {
        public static WithdrawalService RegisterService()
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<WithdrawalService>();
            unityContainer.RegisterType<DataAccessService>();
            unityContainer.RegisterType<AuthenticationService>();
            unityContainer.RegisterType<BalanceCheckerService>();

            unityContainer.RegisterType<IDataAccessService, DataAccessService>();
            unityContainer.RegisterType<IAuthenticationService, AuthenticationService>();
            unityContainer.RegisterType<IBalanceCheckService, BalanceCheckerService>();

            return unityContainer.Resolve<WithdrawalService>();
        }
    }
}

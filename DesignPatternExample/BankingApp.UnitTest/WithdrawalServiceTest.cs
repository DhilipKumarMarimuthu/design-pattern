using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DesignPatternExample;
using DesignPatternExample.Entities.Interface.UnitTesting;
using NSubstitute;

namespace BankingApp.UnitTest
{
    [TestClass]
    public class WithdrawalServiceTest
    {
        //Unit testing is not possible for concrete class implementation of services. We can fix this using dependency inversion principle
        // Putting an abstraction between dependencies we can easily achieve this
        //So we have to implement our application with the design of abstraction. so that the real implemention can be swapped with some fake implementation
        // We can bring the abstraction using interfaces or abstract classes

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Given_UserDetail_When_InvalidUserCredentialUsed_Then_Throw_Exception()
        {
            IAuthenticationService authenticationService = new FakeAuthenticationService(false);
            IBalanceCheckService balanceCheckService = new FakeBalanceCheckService(false);
            //WithdrawalService withdrawalService = new WithdrawalService(authenticationService, new BalanceCheckerService());//Without IOC unity container
            WithdrawalService withdrawalService = new WithdrawalService(authenticationService, balanceCheckService);
            bool isEligible = withdrawalService.IsEligibleToWithDrawal("", "pwd", 123, 0);
            
        }

        [TestMethod]
        public void Given_Any_Amount_When_IsBalanceAvailable_Is_Queried_Then_Return_True()
        {
            var balanceCheckService = Substitute.For<IBalanceCheckService>();
            balanceCheckService.IsBalanceAvailable(123, 500).Returns(true);
            //WithdrawalService withdrawalService = new WithdrawalService(new FakeAuthenticationService(true), new BalanceCheckerService()); //Without IOC unity container
            WithdrawalService withdrawalService = new WithdrawalService(new FakeAuthenticationService(true), new FakeBalanceCheckService(true));
            bool isBalanceAvailable = withdrawalService.IsEligibleToWithDrawal("Dhilip", "pwd", 123, 500);
            Assert.IsTrue(isBalanceAvailable);
        }
    }

    //The reason of using FakeAuthenticationService is because the withdrawal service has dependencies like data access service and we don't want to call actual database call while we testing
    //Instead we simulated the similar behaviour of our service by creating the fake lightweight object to test the particualr unit
    //Now authenticate service method will return what we wish too and never hit the real authentication service
    //The fake object that we are using is completely similar to using mock object by using any mocking framework. If we use mocking framework, the framework will be responsible to create the mock object on our behalf.
    //Again, you can mock appropriately interface or virtual methods
    //Mock framework will work properly only for either interfaces or the classes that can have override methods
    public class FakeAuthenticationService : IAuthenticationService
    {
        bool _isAuthenticated;
        public FakeAuthenticationService(bool isAuthenticated)
        {
            _isAuthenticated = isAuthenticated;
        }

        public bool Authenticate(string userName, string password)
        {
            return _isAuthenticated;
        }
    }

    public class FakeBalanceCheckService : IBalanceCheckService
    {
        bool _isBalanceChecked;
        public FakeBalanceCheckService(bool isBalanceChecked)
        {
            _isBalanceChecked = isBalanceChecked;
        }
        public bool IsBalanceAvailable(int accountNumber, int amount)
        {
            return _isBalanceChecked;
        }
    }
}

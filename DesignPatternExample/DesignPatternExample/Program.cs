using Ardalis.SmartEnum;
using DesignPatternExample.Entities.AbstractClass;
using DesignPatternExample.Entities.ActionFuncDelegates;
using DesignPatternExample.Entities.AnonymouseLambdaMethod;
using DesignPatternExample.Entities.Delegates;
using DesignPatternExample.Entities.Enums;
using DesignPatternExample.Entities.EventsAndDelegates;
using DesignPatternExample.Entities.Interface;
using DesignPatternExample.Entities.Interface.LooselyCoupled;
using DesignPatternExample.Entities.Interface.TightlyCoupled;
using DesignPatternExample.Entities.Interface.UnitTesting;
using DesignPatternExample.Entities.PolymorphismInheritance;
using DesignPatternExample.Entities.PolymorphismInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeSeparator employeeSeparator = new EmployeeSeparator();
            Finance finance = new Finance(employeeSeparator);
            IT it = new IT(employeeSeparator);
            employeeSeparator.Separate();

            DelegateDemo delegateDemo = new DelegateDemo();
            delegateDemo.Print("Am from delegate");

            //delegateDemo.DoLongOperation(UpdatePrintMessage);

            //CustomerPresentation customerPresentation = new CustomerPresentation();
            //customerPresentation.Update();

            /*AnonymouseMethodDemo anonymouseMethodDemo = new AnonymouseMethodDemo();
            anonymouseMethodDemo.CalculateAreaOfRect(5, 5);

            anonymouseMethodDemo.PrintNumber(delegate (int number)
            {
                Console.WriteLine("The updated number : " + number);
            }, 100);

            anonymouseMethodDemo.saveEventHandler += delegate (object sender, EventArgs e)
            {
                Console.WriteLine("Update successfull");
            };
            anonymouseMethodDemo.Save();
            anonymouseMethodDemo.CalculateAreaOfRect(5, 5);
            anonymouseMethodDemo.CalculateAreaOfRectLambda(5, 6);

            LambdaCollectionEx lambdaCollectionEx = new LambdaCollectionEx();
            lambdaCollectionEx.CheckStudentActivities();*/

            // Polymorphism Example using Inheritance
            BusinessFacade businessFacade = new BusinessFacade();

            //Normal implementaiton
            /*Car car = new Car();
            Ship ship = new Ship();
            businessFacade.StartCar(car);
            businessFacade.StopCar(car);
            businessFacade.StartShip(ship);
            businessFacade.StopShip(ship);*/

            //With Base class [Machine] - So initially base class methods got executed
            //Warning	CS0108	'Car.Start()' hides inherited member 'Machine.Start()'. Use the new keyword if hiding was intended
            /*Machine car = new Car();
            Machine ship = new Ship();
            businessFacade.StartCar(car);
            businessFacade.StopCar(car);
            businessFacade.StartShip(ship);
            businessFacade.StopShip(ship);*/

            //Polymorphic way
            //A base class reference variable can point to derived class object
            //Derived class is specialization of base class which means the derived class has all the capabilities of base class
            //Derived class should not hold the base class object

            Machine car = new Car();
            Machine ship = new Ship();

            /*businessFacade.StartMachine(car); //Dynamically decide which machine needs to start. In this case it's car
            businessFacade.StopMachine(car);
            businessFacade.StartMachine(ship); //Dynamically decide which machine needs to start. In this case it's ship
            businessFacade.StopMachine(ship);

            Machine airPlane = new Airplane();
            businessFacade.StartMachine(airPlane); //Dynamically decide which machine needs to start. In this case it's airPlane
            businessFacade.StopMachine(airPlane);
            businessFacade.StartMachine(ship); //Dynamically decide which machine needs to start. In this case it's ship
            businessFacade.StopMachine(ship);*/


            // Polymorphism Example using Interface
            // Polymorphism Example before using Interface
            // Whenever new communication mode introduced [Email mode], communication facede needs to be updated and then the client needs to be updated accordingly
            // This makes the code fragile and error prone. Also the complete testing needs to be done.
            // So to achieve this, we have to use Polymorphism using Interface
            CommunicationFacade communicationFacade = new CommunicationFacade();
            /*VoiceMode voiceMode = new VoiceMode();
            TextMode textMode = new TextMode();
            EmailMode emailMode = new EmailMode();

            CommunicationFacade communicationFacade = new CommunicationFacade();
            Console.WriteLine("Please enter the type of communication mode you want to start [1 - Voice, 2 - Text, 3 - Email]");
            var mode = int.Parse(Console.ReadLine());
            if(mode == 1)
            {
                Thread.Sleep(1000);
                communicationFacade.StartCommunication(voiceMode);
            } else if (mode == 1)
            {
                Thread.Sleep(1000);
                communicationFacade.StartCommunication(textMode);
            } else if (mode == 1)
            {
                Thread.Sleep(1000);
                communicationFacade.StartCommunication(emailMode);
            }*/

            // Polymorphism Example after using Interface
            // Advantage of Polymorphism : It promotes extensibility - By allowing new sub classes and methods to be added to a class hierarchy without having to modify existing programs.
            // Code became more loosly coupled. When we add a new communication there is no change in facade and client code
            // Facade doesn't do what it's doing. It just know to call the communicate method depends upon the object
            /*Console.WriteLine("Please enter the type of communication mode you want to start [1 - Voice, 2 - Text, 3 - Email]");
            var mode = int.Parse(Console.ReadLine());
            ICommunication factory = CommunicationFactory.Create(mode);
            communicationFacade.StartCommunication(factory);*/

            //Polymorphic behaviour of toString() method

            /*LambdaCollectionEx lambdaCollectionEx = new LambdaCollectionEx();
            lambdaCollectionEx.CheckStudentActivities(); */

            //Core Abstraction Demo
            /*FrothyCreamingCoffee frothyCreamingCoffee = new FrothyCreamingCoffee(2,2,2);
            PrepareCoffee(frothyCreamingCoffee);

            IceCoffee iceCoffee = new IceCoffee(3, 3, 3, 3);
            PrepareCoffee(iceCoffee);*/

            //Adding the new type of coffee is Rigid and not maintainable if we follow the above approach.
            //So create the abstract class to achieve this in Polymorphic way

            /*IceCoffee iceCoffee = new IceCoffee(3, 3, 3, 3);
            PrepareCoffee(iceCoffee);
            FrothyCreamingCoffee frothyCreamingCoffee = new FrothyCreamingCoffee(2, 2, 2);
            PrepareCoffee(frothyCreamingCoffee);
            Expresso expresso = new Expresso();
            PrepareCoffee(expresso);*/

            //Interface Implementation
            // Tightly Coupled Way
            /*CreditCardPayment creditCardPayment = new CreditCardPayment();
            DebitCardPayment debitCardPayment = new DebitCardPayment();
            GooglePay googlePay = new GooglePay();
            PaymentManager paymentManager = new PaymentManager(debitCardPayment, creditCardPayment, googlePay);
            paymentManager.ManagePayment();*/

            // Loosely Coupled Way
            /*IPaymentMode paymentMode = PaymentModeFactory.Create(PaymentMode.DebitCard);
            PaymentManagerLC paymentManagerLC = new PaymentManagerLC(paymentMode);
            paymentManagerLC.ManagePayment();*/

            //Interface - Unit Testing
            // A good project may well have more test code than production code
            // 1.   Bugs are found easily and early
            // 2.   Saves Time and Money
            // 3.   A safety net for refactoring or any any enhancements

            // Concrete class implementation
            /*var userName = "Dhilip";
            WithdrawalService withdrawalService = new WithdrawalService();
            var isEligible = withdrawalService.IsEligibleToWithDrawal(userName, "pwd", 123, 1000);
            if(isEligible)
                Console.WriteLine($"{userName} is eligible to withdraw");
            else
                Console.WriteLine($"{userName} is not eligible to withdraw");*/

            // Interface implementation
            /*var userName = "Dhilip";
            IAuthenticationService authenticationService = new AuthenticationService();
            IBalanceCheckService balanceCheckService = new BalanceCheckerService();
            WithdrawalService withdrawalService = new WithdrawalService(authenticationService, balanceCheckService);
            var isEligible = withdrawalService.IsEligibleToWithDrawal(userName, "pwd", 123, 1000);
            if (isEligible)
                Console.WriteLine($"{userName} is eligible to withdraw");
            else
                Console.WriteLine($"{userName} is not eligible to withdraw"); */


            // Interface - Dependency Injection
            // We should avoid to creating concrete class instances using new keyword instead you should depend on abstraction perhaps using an interface where by letting the dependencies
            // to be created by someone else for you in an abstract manner and use them by injecting whenever required.
            // DI - Creates objects outside of a class and provides those objects to a class through injection mainly constrctor
            // Interfaces achieves - Maintainability, Testability, Flexibility, Extensibility
            // IOC Container - Framework for implementing automatic dependency injection 
            //                 Dependencies chain can become nested and complex. IOC container centralizes the creation of your dependencies and manages its lifetime.
            // Interface + Dependency Injection + IOC Container = Almost Zero "New" Keyword   
            //AuthenticationService :  _dataAccessService = new DataAccessService();
            //BalanceCheckerService :  _dataAccessService = new DataAccessService();
            //Program.cs[Client]    : IAuthenticationService authenticationService = new AuthenticationService(); IBalanceCheckService balanceCheckService = new BalanceCheckerService();

            /*var userName = "Dhilip";
            WithdrawalService withdrawalService = AppunityContainer.RegisterService();
            var isEligible = withdrawalService.IsEligibleToWithDrawal(userName, "pwd", 123, 1000);
            if (isEligible)
                Console.WriteLine($"{userName} is eligible to withdraw");
            else
                Console.WriteLine($"{userName} is not eligible to withdraw");*/

            // Enum implementation using SmartEnum NuGet package

            CustomerEnumDemo customerEnumDemo = new CustomerEnumDemo();
            customerEnumDemo.Id = 123;
            customerEnumDemo.Type = new AbstractCustomerType.RegularType();
            Console.WriteLine($"Discount for {customerEnumDemo.Type.Name} type is : {customerEnumDemo.CalculateDiscount(123)}");

            Console.ReadKey();
        }

        private static void PrepareCoffee(CoffeeBase coffeeBase)
        {
            coffeeBase.Prepare();
        }

        private static void PrepareCoffee(FrothyCreamingCoffee frothyCreamingCoffee)
        {
            frothyCreamingCoffee.Prepare();
        }

        private static void PrepareCoffee(IceCoffee iceCoffee)
        {
            iceCoffee.Prepare();
        }

        private static void UpdatePrintMessage(int itemNumber)
        {
            Console.WriteLine("Item : " + itemNumber.ToString());
            Console.WriteLine();
        }
    }
}

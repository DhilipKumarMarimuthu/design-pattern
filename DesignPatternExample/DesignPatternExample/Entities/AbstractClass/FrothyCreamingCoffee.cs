using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.AbstractClass
{
    //Abstract class is a class where we have atleast one property or method as abstract and we can't instrantiate an abstract class becauseit's not a real business entity.
    //It doesn't make to instantiate and it's indended to be inherited only.
    //Abstract class and Polymorphism are related. Abstract class is used to achieve polymorphism in your class

    //Real world example - Coffee Making
    //Frothy Creamy Coffee
    //Ingredients : Instant Coffee, Sugar, Hot Water, Milk
    //Preparation Process
    //{
    //  Put sugar and coffee in a bowl
    //  Add little hot water
    //  Mix it for 2-3 minutes by adding little water
    //  Add hot milk and coffee is ready

    //}
    /*class FrothyCreamingCoffee
    {
        private readonly int coffeeQuan;
        private readonly int sugarQuan;
        private readonly int milkQuan;

        public FrothyCreamingCoffee(int coffeeQuan, int sugarQuan, int milkQuan)
        {
            this.coffeeQuan = coffeeQuan;
            this.milkQuan = milkQuan;
            this.sugarQuan = sugarQuan;
        }

        public void Prepare()
        {
            CreateMixer();
            Console.WriteLine("Frothy Creaming Coffee is ready");
        }

        public void CreateMixer()
        {
            Console.WriteLine($"Create mixer of {coffeeQuan}, {milkQuan} and {sugarQuan}");
        }
    }*/
    //Polymorphic way [Abstract way]

    class FrothyCreamingCoffee : CoffeeBase
    {
        public FrothyCreamingCoffee(int coffeeQuan, int sugarQuan, int milkQuan) : 
            base(coffeeQuan, sugarQuan, milkQuan)
        {
        }

        public override void Prepare()
        {
            CreateMixer();
            Console.WriteLine("Frothy Creaming Coffee is ready");
        }

    }
}

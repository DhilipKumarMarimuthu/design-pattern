using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.AbstractClass
{
    /*class IceCoffee
    {
        private readonly int coffeeQuan;
        private readonly int sugarQuan;
        private readonly int milkQuan;
        private readonly int iceQuan;

        public IceCoffee(int coffeeQuan, int sugarQuan, int milkQuan, int iceQuan)
        {
            this.coffeeQuan = coffeeQuan;
            this.milkQuan = milkQuan;
            this.sugarQuan = sugarQuan;
            this.iceQuan = iceQuan;
        }
        public void Prepare()
        {
            CreateMixure();
            Console.WriteLine("Ice Coffee is ready");
        }

        public void CreateMixure()
        {
            Console.WriteLine($"Create mixer of {coffeeQuan}, {milkQuan}, {iceQuan} and {sugarQuan}");
        }
    }*/

    class IceCoffee : CoffeeBase
    {
        private readonly int iceQuan;

        public IceCoffee(int coffeeQuan, int sugarQuan, int milkQuan, int iceQuan) : 
            base(coffeeQuan, sugarQuan, milkQuan)
        {
            this.iceQuan = iceQuan;
        }
        public override void Prepare()
        {
            CreateMixer();
            Console.WriteLine("Ice Coffee is ready");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace DesignPatternExample.Entities.Enums
{
    public abstract class AbstractCustomerType : SmartEnum<AbstractCustomerType>
    {
        private AbstractCustomerType(string name, int value) : base(name, value) { }


        public static readonly AbstractCustomerType Regular = new RegularType();
        public static readonly AbstractCustomerType Gold = new GoldType();
        public static readonly AbstractCustomerType Premium = new PremiumType();

        public abstract double Calculate(int amount);

        public sealed class RegularType : AbstractCustomerType
        {
            public RegularType() : base("Regular", 1) { }

            public override double Calculate(int amount) => amount * 0.10;
        }

        public sealed class GoldType : AbstractCustomerType
        {
            public GoldType() : base("Gold", 2) { }

            public override double Calculate(int amount) => amount * 0.20;
        }

        public sealed class PremiumType : AbstractCustomerType
        {
            public PremiumType() : base("Premium", 3) { }

            public override double Calculate(int amount) => amount * 0.30;
        }
    }
}

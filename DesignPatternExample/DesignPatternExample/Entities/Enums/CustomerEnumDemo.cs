using DesignPatternExample.Entities.DockerDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Enums
{
    public class CustomerEnumDemo
    {
        //Traditional way of consuming enums
        /*public int Id { get; set; }
        public CustomerType Type { get; set; }

        public double CalculateDiscount(int amount)
        {
            switch (Type)
            {
                case CustomerType.Regular:
                    return amount * 0.30;
                case CustomerType.Gold:
                    return amount * 0.40;
                case CustomerType.Premium:
                    return amount * 0.50;
                default:
                    return amount * 0.30;
            }
        }*/


        //Using SmartEnum

        public int Id { get; set; }
        public AbstractCustomerType Type { get; set; }

        public double CalculateDiscount(int amount) => Type.Calculate(amount);
    }

}

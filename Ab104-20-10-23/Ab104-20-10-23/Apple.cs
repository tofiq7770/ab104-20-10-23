using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_20_10_23
{
    public class Apple : Fruit
    {
        public double VitaminA { get; set; }
        public double VitaminB { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Apple's taste");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_20_10_23
{
    public class Pineapple : Fruit
    {
        public double VitaminE { get; set; }
        public double VitaminD { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Pineapple's taste");
        }
    }
}

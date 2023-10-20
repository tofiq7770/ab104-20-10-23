using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_20_10_23
{
    public class Orange : Fruit
    {
        public double VitaminC { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Orange's taste");
        }
    }

}

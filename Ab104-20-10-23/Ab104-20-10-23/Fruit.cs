﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_20_10_23
{
    public abstract class Fruit
    {
        public decimal Price { get; set; }
        public string Sort { get; set; }

        public abstract void Taste();
    }
}

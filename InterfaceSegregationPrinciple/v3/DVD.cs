﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.v3
{
   public class DVD:IMovie
    {
       public decimal Price { get; set; }
       public double Weight { get; set; }
       public int Stock { get; set; }
       public int RunningTime { get; set; }
    }
}
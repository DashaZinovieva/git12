﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git.phesicslogic
{
    internal class pifagor
    {
        public static int Calculate(int n)
        {
            int res = 1;
            for (int i = 0; i < n; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}

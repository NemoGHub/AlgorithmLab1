﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLab1_console_.Algorithms.PowAlgorithms
{
    internal class RecPow : PowAlgorithm
    {
        public override void ExecuteAlgorithm(int[] vector, int n)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = Pow(vector[i], n);
            }
        }
        private int Pow(int x, int n)
        {
            f = 0;
            if (n == 0)
            {
                f = 1;
            }
            else
            {
                f = Pow(x, n / 2);

                f = n % 2 == 1 ? f * f * x : f * f;
            }

            return f;
        }
    }
}

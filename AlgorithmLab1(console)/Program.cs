﻿using AlgorithmLab1;
using AlgorithmLab1_console_.Algorithms;
using AlgorithmLab1_console_.Algorithms.PowAlgorithms;
using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLab1_console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ExchangeSort sort = new ExchangeSort();

            int[] vector = Generator.VectorInput(2000);
            sort.ExecuteAlgorithm(vector);

            Console.WriteLine(String.Join(" ", vector));*/

            /*Pow s = new Pow();

            int x = 2;
            int n = 10;

            s.ExecuteAlgorithm(ref x, n);

            Console.WriteLine(x);*/

            double[] b = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            double[] a = { 0.008, 0.002, 0.004, 0.006, 0.004, 0.004, 0.004, 0.004, 0.004, 0.004 };
            double[] time = Fit.Polynomial(b, a, 3);

            foreach (double t in time)
            {
               Console.WriteLine(t.ToString());
            }
        }
    }
}

﻿using AlgorithmLab1;
using AlgorithmLab1_console_.Algorithms.PowAlgorithms;
using AlgorithmLab1_console_.Algorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLab1_console_
{
    internal class Analyzer
    {
        public static double[] Timing(int n, int start, int steps, int repeats, Algorithm algorithm)
        {
            List<double> tests = new List<double>();

            for (int i = start; i < n; i += steps)
            {
                double totalTime = 0;

                for (int j = 0; j < repeats; j++)
                {
                    int[] vector = Generator.VectorInput(i + 1);

                    Stopwatch stopwatch = Stopwatch.StartNew();
                    algorithm.ExecuteAlgorithm(vector);
                    stopwatch.Stop();

                    totalTime += stopwatch.Elapsed.TotalMilliseconds;
                }

                tests.Add(totalTime / repeats);
            }

            double[] test = tests.ToArray();
            return test;
        }

        public static double[] Timing(int n, int repeats, PowAlgorithm algorithm, int power)
        {
            double[] tests = new double[n];

            for (int i = 0; i < n; i++)
            {
                double totalTime = 0;

                for (int j = 0; j < repeats; j++)
                {
                    int[] vector = Generator.VectorInput(i + 1);

                    Stopwatch stopwatch = Stopwatch.StartNew();
                    algorithm.ExecuteAlgorithm(vector, power);
                    stopwatch.Stop();

                    totalTime += stopwatch.Elapsed.TotalMilliseconds;

                }

                tests[i] = totalTime / repeats;
            }
            return tests;
        }

        public static double[] Timing(int n, int start, int steps, int repeats, MatrixMultiplication algorithm)
        {
            List<double> tests = new List<double>();

            for (int i = start; i < n; i += steps)
            {
                double totalTime = 0;

                for (int j = 0; j < repeats; j++)
                {
                    int[,] matrix1 = Generator.MatrixInput(i + 1);
                    int[,] matrix2 = Generator.MatrixInput(i + 1);

                    Stopwatch stopwatch = Stopwatch.StartNew();
                    algorithm.ExecuteAlgorithm(matrix1, matrix2);
                    stopwatch.Stop();

                    totalTime += stopwatch.Elapsed.TotalMilliseconds;

                }

                tests.Add(totalTime / repeats);
            }

            double[] test = tests.ToArray();
            return test;
        }

        public static double[] Timing(int n, int start, int steps, int repeats, SumOfRows algorithm)
        {
            List<double> tests = new List<double>();

            for (int i = start; i < n; i += steps)
            {
                double totalTime = 0;

                for (int j = 0; j < repeats; j++)
                {
                    int[,] matrix = Generator.MatrixInput(i + 1);

                    Stopwatch stopwatch = Stopwatch.StartNew();
                    algorithm.ExecuteAlgorithm(matrix);
                    stopwatch.Stop();

                    totalTime += stopwatch.Elapsed.TotalMilliseconds;

                }

                tests.Add(totalTime / repeats);
            }

            double[] test = tests.ToArray();
            return test;
        }
    }
}
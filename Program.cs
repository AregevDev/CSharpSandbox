using System;
using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra;

namespace CSharpSandbox
{
    class Program
    {
        public static void Main(string[] args)
        {
            var vecA = Vector<double>.Build.DenseOfArray(new double[] { 1, 2, 3 });
            var vecB = Vector<double>.Build.DenseOfArray(new double[] { 4, 5, 6 });
            
            System.Console.WriteLine(vecA + vecB);
        }
    }
} 

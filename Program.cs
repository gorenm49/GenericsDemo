using System;

namespace GenericsDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GenDemo demo = new GenDemo();
            int[] a1 = {1,2,3,4,5};
            double[] d1 = {1.2,1.4,3.4,2.3};
            char[] c1 = {'a', 'b','c'};

            demo.PrintDemo<int>(a1);
            demo.PrintDemo<double>(d1);
            demo.PrintDemo<char>(c1);

            ClassUsingGenerics<int> demoI = new ClassUsingGenerics<int>();
            demoI.PrintDemo(a1);

            ClassUsingGenerics<double> demoD = new ClassUsingGenerics<double>();
            demoD.PrintDemo(d1);

            ClassUsingGenerics<char> demoC = new ClassUsingGenerics<char>();
            demoC.PrintDemo(c1);
        }
    }
    
}
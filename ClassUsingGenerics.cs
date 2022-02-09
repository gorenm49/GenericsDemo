using System;

namespace GenericsDemo
{
    public class ClassUsingGenerics<T>
    {
        public void PrintDemo(T[] arr)
        {

            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }
        }

    }
}
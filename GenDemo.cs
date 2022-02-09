using System;

namespace GenericsDemo
{
    public class GenDemo
    {
        public void PrintDemo<T>(T[] arr)
        {

            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
using System;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton objA = Singleton.GetInstance();
            Singleton objB = Singleton.GetInstance();

            if (objA != objB)
            {
                Console.WriteLine("Not same");
            }
            else
            {
                Console.WriteLine("Both are same");
            }
        }
    }
}

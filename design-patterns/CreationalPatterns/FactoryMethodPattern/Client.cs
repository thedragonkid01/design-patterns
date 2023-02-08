using FactoryMethodPattern.Creators;
using System;

namespace FactoryMethodPattern
{
    internal class Client
    {
        private readonly Creator _creator;
        public Client(Creator creator)
        {
            _creator = creator;
        }

        public void DoOperation()
        {
            Console.WriteLine("Client do operation");
            _creator.DoOperation();
        }
    }
}

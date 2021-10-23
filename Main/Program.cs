using System;
using Faker;
using Faker.BaseTypes;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            IGenerator i = new ByteGenerator();
            Console.WriteLine(i.GeneratorType);
        }
    }
}

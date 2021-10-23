using System;
using Faker;
using Faker.BaseTypes;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Faker.Faker f = new Faker.Faker();
            FooBar ff = f.Create<FooBar>();

            Console.WriteLine(ff.ToString());






        }
    }
}

using System;
using Newtonsoft.Json;
using Faker;
using Faker.BaseTypes;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Faker.Faker f = new Faker.Faker();
            Bar ff = f.Create<Bar>();
            Console.WriteLine(JsonConvert.SerializeObject(ff,Formatting.Indented));

            Console.WriteLine(ff.ToString());






        }
    }
}

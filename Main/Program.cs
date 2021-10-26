using System;
using Newtonsoft.Json;
using Faker;
using Faker.BaseTypes;
using System.Collections.Generic;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Faker.Faker f = new Faker.Faker();
            Bar ff = f.Create<Bar>();
            //ICollection<int> ff = f.Create<List<int>>();
            Console.WriteLine(JsonConvert.SerializeObject(ff,Formatting.Indented));

            //Console.WriteLine(ff.ToString());






        }
    }
}

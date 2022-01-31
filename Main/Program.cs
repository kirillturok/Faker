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
            //Bar ff = f.Create<Bar>();
            User ff = f.Create<User>();
            Console.WriteLine(JsonConvert.SerializeObject(ff,Formatting.Indented));

            //Console.WriteLine(ff.ToString());






        }
    }

    class User
    {
        public string name;
        public int age {get; set; }
        float money = 10.05f;
        //public List<Dog> dogs;
        public Dog dog;
        public Profile profile;

    }

    class Dog
    {
        public String name;
        public User owner;

    }

    class Profile
    {
        public String address;
        public Profile()
        {

        }
        public Profile(string addr)
        {
            //throw new Exception();
            //address = addr;
        }
    }
}

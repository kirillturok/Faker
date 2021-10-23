using System;
using Faker;

namespace UshortGeneratorPlugin
{
    class UshortGeneratorPlugin:IGenerator
    {
        public Type GeneratorType => typeof(ushort);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public object Create()
        {
            return (ushort)(new Random().Next(ushort.MinValue, ushort.MaxValue));
        }
    }
}

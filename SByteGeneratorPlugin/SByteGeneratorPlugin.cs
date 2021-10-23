using System;
using Faker;

namespace SByteGeneratorPlugin
{
    public class SByteGeneratorPlugin:IGenerator
    {
        public Type GeneratorType => typeof(sbyte);

        public object Create()
        {
            return (sbyte)(new Random().Next(sbyte.MinValue,sbyte.MaxValue));
        }



        public static void Main(string[] args)
        {

        }
    }

    
}

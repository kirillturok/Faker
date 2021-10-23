using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    public class CharGenerator : IGenerator
    {
        static string Symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        public Type GeneratorType => typeof(Char);

        public object Create()
        {
            return Symbols[new Random().Next(Symbols.Length)];
        }
    }
}

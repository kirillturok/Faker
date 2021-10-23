using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    class CharGenerator : IGenerator
    {
        public Type GeneratorType => typeof(Char);

        public object Create()
        {
            return new Random().Next(char.MinValue,char.MaxValue);
        }
    }
}

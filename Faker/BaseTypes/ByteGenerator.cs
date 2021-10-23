using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    public class ByteGenerator : IGenerator
    {
        public Type GeneratorType => typeof(byte);

        public object Create()
        {
            return (byte)(new Random().Next(byte.MinValue,byte.MaxValue));
        }
    }
}

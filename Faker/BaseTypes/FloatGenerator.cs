using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    public class FloatGenerator : IGenerator
    {
        public Type GeneratorType => typeof(float);

        public object Create()
        {
            return (float)(new Random().NextDouble());
        }
    }
}

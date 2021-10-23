using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    public class IntGenerator : IGenerator
    {
        public Type GeneratorType => typeof(int);

        public object Create()
        {
            return new Random().Next(int.MinValue,int.MaxValue);
        }
    }
}

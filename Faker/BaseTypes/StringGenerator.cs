using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    public class StringGenerator : IGenerator
    {
        public Type GeneratorType => typeof(string);

        public object Create()
        {
            Random random = new Random();
            int length = random.Next(byte.MaxValue);
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < length; i++)
            {
                char symb = (char)(random.Next(char.MinValue, char.MaxValue));
                builder.Append(symb);
            }
            return builder.ToString();
        }
    }
}

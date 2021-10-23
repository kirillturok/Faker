using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    public class DateGenerator : IGenerator
    {
        public Type GeneratorType => typeof(DateTime);

        public object Create()
        {
            Random gen = new Random();
            DateTime start = new DateTime(2000, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    class BoolGenerator : IGenerator
    {
        public Type GeneratorType => typeof(bool);

        public object Create()
        {
            return new Random().Next(0,1)==1;
        }
    }
}

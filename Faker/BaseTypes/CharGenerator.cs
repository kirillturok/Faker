﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    public class CharGenerator : IGenerator
    {
        public Type GeneratorType => typeof(Char);

        public object Create()
        {
            return (char)(new Random().Next(char.MinValue,char.MaxValue));
        }
    }
}

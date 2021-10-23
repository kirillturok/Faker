﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public interface IGenerator
    {
        object Create();
        Type GeneratorType { get; }
    }
}

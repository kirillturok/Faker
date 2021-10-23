using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class FooBar
    {
        public Foo he123;
        public int hello;
        public float ft;
        public double ahahah;
        public long test { get; set; }
    }
    class Bar
    {
        public long pamagitiFaker;
        public Foo hello;
        private readonly int some;
        public long a;
        public int Some { get; set; }
        public long Long { get; set; }

        public Bar(int some)
        {
            this.some = some;
        }

        public int ValueSome { get { return this.some; } }
    }

    class Foo
    {
        public Bar bar;
    }
}

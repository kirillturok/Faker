using System.Collections.Generic;

namespace Main
{
    class Bar
    {
        public long longBar;
        public Foo fooBar;
        private readonly int intBar;
        public long a;
        public int Some { get; set; }
        public long Long { get; set; }

        public Bar(int intBar)
        {
            this.intBar = intBar;
        }

        public int ValueSome { get { return this.intBar; } }
    }

    class Foo
    {
        public Some he123;
        public int intFoo;
        public List<int> list;
        public float floatFoo;
        public double doubleFoo;
        public long test { get; set; }
    }

    class Some
    {
        public Bar bar;
    }   
}

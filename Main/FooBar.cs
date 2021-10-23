namespace Main
{
    class FooBar
    {
        public Foo fooInBar;
        public int FBInt;
        public float floatFB;
        public double doubleFB;
        public long longFB;
    }
    class Bar
    {
        public long longB;
        public Foo fooB;
        private readonly int intB;
        public string stringB;
        public Bar(int longB)
        {
            this.longB = longB;
        }

        public int ValueSome { get { return this.intB; } }
    }

    class Foo
    {
        public Bar bar;
    }
}

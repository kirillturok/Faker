using Faker;
using NUnit.Framework;

namespace TestProject1
{
    class SimpleClassCreation
    {
        [Test]
        public void simpleClassTest()
        {
            Faker.Faker faker = new Faker.Faker();
            A a = faker.Create<A>();
            Assert.AreEqual(a._int == default(int), false, "Variable int _int in A class hasn't been initialized.");
            Assert.AreEqual(a._byte == default(byte), false, "Variable byte _byte in A class hasn't been initialized.");
            Assert.AreEqual(a._string == null, false, "Variable string _string in A class hasn't been initialized.");
            Assert.AreEqual(a.b == null, false, "Variable B b in A class hasn't been initialized.");
            Assert.AreEqual(a.b._double == default(double), false, "Variable double _double in B class hasn't been initialized.");
        }
    }

    class A
    {
        public int _int;
        public byte _byte;
        public string _string;
        public bool _bool;
        public B b;

        public A(string str)
        {
            _string = str;
        }
    }

    class B
    {
        public double _double;
    }
}

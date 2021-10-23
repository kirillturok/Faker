using NUnit.Framework;
using Faker;
using Faker.BaseTypes;
using System;

namespace TestProject1
{
    public class GeneratorTest
    {
        [Test]
        public void byteTest()
        {
            IGenerator byteGen = new ByteGenerator();
            object o = byteGen.Create();
            Assert.AreEqual(o.GetType(),typeof(byte),"Byte generator returns another type.");
        }

        [Test]
        public void boolTest()
        {
            IGenerator boolGen = new BoolGenerator();
            object o = boolGen.Create();
            Assert.AreEqual(o.GetType(), typeof(bool), "Bool generator returns another type.");
        }

        [Test]
        public void charTest()
        {
            IGenerator charGen = new CharGenerator();
            object o = charGen.Create();
            Assert.AreEqual(o.GetType(), typeof(char), "Char generator returns another type.");
        }

        [Test]
        public void dateTest()
        {
            IGenerator gen = new DateGenerator();
            object o = gen.Create();
            Assert.AreEqual(o.GetType(), typeof(DateTime), "Date generator returns another type.");
        }

        [Test]
        public void doubleTest()
        {
            IGenerator gen = new DoubleGenerator();
            object o = gen.Create();
            Assert.AreEqual(o.GetType(), typeof(double), "Double generator returns another type.");
        }

        [Test]
        public void floatTest()
        {
            IGenerator gen = new FloatGenerator();
            object o = gen.Create();
            Assert.AreEqual(o.GetType(), typeof(float), "Float generator returns another type.");
        }

        [Test]
        public void intTest()
        {
            IGenerator gen = new IntGenerator();
            object o = gen.Create();
            Assert.AreEqual(o.GetType(), typeof(int), "Int generator returns another type.");
        }

        [Test]
        public void longTest()
        {
            IGenerator gen = new LongGenerator();
            object o = gen.Create();
            Assert.AreEqual(o.GetType(), typeof(long), "Long generator returns another type.");
        }

        [Test]
        public void shortTest()
        {
            IGenerator gen = new ShortGenerator();
            object o = gen.Create();
            Assert.AreEqual(o.GetType(), typeof(short), "Short generator returns another type.");
        }

        [Test]
        public void stringTest()
        {
            IGenerator gen = new StringGenerator();
            object o = gen.Create();
            Assert.AreEqual(o.GetType(), typeof(string), "String generator returns another type.");
        }
    }
}
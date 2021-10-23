using NUnit.Framework;
using Faker;
using System.Collections.Generic;
using System;

namespace TestProject1
{
    class PluginTest
    {
        [Test]
        public void PluginLoadTest()
        {
            Dictionary<Type, IGenerator> plugins=new Dictionary<Type, IGenerator>();
            PluginLoader loader = new PluginLoader(plugins);
            loader.LoadPluginGenerators();
            Assert.AreEqual(plugins.Count, 2, "Wrong number of loaded plugins");
        }

        [Test]
        public void PluginGeneratorsTest()
        {
            Faker.Faker faker = new Faker.Faker();
            object o1 = faker.Create<sbyte>();
            Assert.AreEqual(o1.GetType(), typeof(sbyte), "Sbyte generator from plugin returned wrong type.");
            object o2 = faker.Create<ushort>();
            Assert.AreEqual(o2.GetType(), typeof(ushort), "Ushort generator from plugin returned wrong type.");
        }
    }
}

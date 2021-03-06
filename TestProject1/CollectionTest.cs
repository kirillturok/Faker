using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Faker;

namespace TestProject1
{
    class CollectionTest
    {
        [Test]
        public void CollectionCreate()
        {
            Faker.Faker faker = new Faker.Faker();
            List<int> list = faker.Create<List<int>>();
            ICollection<double> icoll = faker.Create<ICollection<double>>();
            List<List<char>> difficult = faker.Create<List<List<char>>>();
            Assert.AreEqual(list == null, false, "List list hasn't been initialized.");
            char b = difficult[0][0];
            Assert.AreEqual(b == default(char), false, "Item in List of Lists hasn't been initialized.");
        }
    }
}

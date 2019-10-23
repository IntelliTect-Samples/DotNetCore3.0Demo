using DemoContext;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;
using System.Text.Json;

namespace ConsoleDemoTest
{
    public class SuperDbContextTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MethodTest()
        {
            var options = new DbContextOptionsBuilder<SuperDbContext>()
                .UseInMemoryDatabase(databaseName: "SuperTester")
                .Options;
            var db = new SuperDbContext(options);
            db.SuperHeroes.Add(new SuperHero { Name = "Dianna Prince", SuperHeroId = 1, SuperName = "Wonder Woman" });
            db.SuperHeroes.Add(new SuperHero { Name = "Bruce Banner", SuperHeroId = 2, SuperName = "The Hulk" });
            db.SaveChanges();

            Assert.AreEqual(2, db.SuperHeroes.Count());

            var wonders = db.SuperHeroes.Where(f => f.StartsWith("Wonder"));
            Assert.Catch<InvalidOperationException>(() => { wonders.Count(); });

            var newWonders = db.SuperHeroes.Where(f => f.SuperName.StartsWith("Wonder"));
            Assert.AreEqual(1, newWonders.Count());

            string test = null;
            test = "test";
            Assert.AreEqual("test", test);
        }
    }
}
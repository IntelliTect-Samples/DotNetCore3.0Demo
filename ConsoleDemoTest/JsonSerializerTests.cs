using NUnit.Framework;
using System;
using System.Text.Json;

namespace ConsoleDemoTest
{
    public class JsonSerializerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        public class SuperHero
        {
            public string Name { get; set; }
            public string SuperName { get; set; }
            public string[] Enemies { get; set; }
        }

        [Test]
        public void JsonSerializerRoundTripTest()
        {
            var super = new SuperHero
            {
                Name = "Diana Prince",
                SuperName = "Wonder Woman",
                Enemies = new string[] { "Cheetah", "Silver Swan" }
            };

            var superJson = System.Text.Json.JsonSerializer.Serialize(super);

            var anotherSuper = JsonSerializer.Deserialize<SuperHero>(superJson);

        }
    }
}
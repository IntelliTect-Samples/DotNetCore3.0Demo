using NUnit.Framework;
using System;

namespace ConsoleDemoTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5 };
            Assert.AreEqual(4, arr[^2]);
            Assert.AreEqual(5, arr[^1]);

            Index i1 = 2;
            Assert.AreEqual(2, arr[i1]);
            Index i2 = ^2;
            Assert.AreEqual(4, arr[i2]);
            Index i3 = 0;
            Assert.AreEqual(0, arr[i3]);
            Index i4 = 1;
            Assert.AreEqual(1, arr[i4]);
            Index i5 = ^0;
            Assert.Catch(typeof(IndexOutOfRangeException), () => { 
                Assert.AreEqual(5, arr[i5]);
            });


        }
    }
}
using System.Collections.Generic;
using System.ComponentModel;
using MyMset.UnitTestt;
using Newtonsoft.Json.Linq;


namespace TestProject1
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
            // Assert.Pass();
            string s = UnitTestt.MyTrim("  ali reza  ");
            Assert.That(s, Is.EqualTo("ali reza"), $"{s} test passed");
        }

      
        [TestCase(" ali reza ") ]
        [TestCase(" ali reza  ")]
        [TestCase("    ali reza ")]
        [TestCase("ali   reza")]
        [NUnit.Framework.Category("TestCaseCategory")]
        public void TestCase1(string value)
        {
            string s = UnitTestt.MyTrim(value);
            Assert.That(s, Is.EqualTo("ali reza"), $"{value} test passed ={s}");

        }
    }
}
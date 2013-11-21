using System;
using NUnit.Framework;
using Should;

namespace AutoParse.Tests
{
    [TestFixture]
    public class ScratchTests
    {

        [Test]
        public void should_parse_value()
        {
            var val = "20131025".TryParse<DateTime>(DateTime.TryParse);
            Console.WriteLine(val);
        }
    }
}
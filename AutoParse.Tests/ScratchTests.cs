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
            Console.WriteLine("0009998".TryParse<int>());
            Console.WriteLine("0009998".TryParse<long>());
            Console.WriteLine("0009998".TryParse<double>());

            Console.WriteLine("10-25-2013".TryParseNullable<DateTime>().HasValue);
        }
    }
}
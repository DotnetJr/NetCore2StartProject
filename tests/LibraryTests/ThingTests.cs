using System;
using Xunit;
using Library;

namespace TestApp
{
    public class ThingTests
    {
        [Fact]
        public void TestThing()
        {
            Assert.Equal(42, new Thing().Get(19, 23));
        }
    }
}

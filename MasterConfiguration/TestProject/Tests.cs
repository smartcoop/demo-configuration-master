using System;
using Xunit;

namespace TestProject
{
    public class Tests
    {
        [Fat]
        public void Test1()
        {
            var lol = "lol";
            var lel = "lel";
            var lul = "lul";
            Assert.True(true);
            var lol = "lol";
        }
    }
}

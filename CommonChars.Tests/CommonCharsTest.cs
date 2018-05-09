using System;
using System.ComponentModel.DataAnnotations;
using NUnit.Framework;

namespace CommonChars.Tests
{
    [TestFixture]
    public class CommonCharsTest
    {
        [TestCase("kutay", "kalkan", ExpectedResult = "ka")]
        [TestCase("aaa", "bbb", ExpectedResult = "")]
        public string Test(string a, string b)
        {
            CommonChars commonChars = new CommonChars();
            return commonChars.FindCommonChars(a, b);
        }

        [Test]
        public void ThrowExceptionWhenNullInput()
        {
            CommonChars commonChars = new CommonChars();
            Assert.Throws<ArgumentNullException>(() => commonChars.FindCommonChars(null, null),
                "Input strings can not be null");
        }
    }
}

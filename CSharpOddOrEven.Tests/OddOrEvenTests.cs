using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;

namespace CSharpOddOrEven.Tests
{
    [TestClass]
    public class OddOrEvenTests
    {
        private readonly ILogger logger = NullLoggerFactory.Instance.CreateLogger("Test");

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}

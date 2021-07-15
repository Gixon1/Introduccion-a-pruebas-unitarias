using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Autenticar_Test
{
    [TestClass]
    public class UnitTest1 : UnitTest1Base
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = Autenticar.Program.Something();
            Assert.AreEqual("Algo", result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Autenticar_Test
{
    [TestClass]
    public class UnitTest1Base
    {

        [TestMethod]
        public void TestLoginTrue()
        {
            bool result = Autenticar.Program.Login("Gixon", "123478");
            Assert.AreEqual(true, result);
        }

       
    }
}
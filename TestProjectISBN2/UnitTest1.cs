using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;


namespace TestProjectISBN2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] ISBN = new int[] { 9,7,8,0,7,1,6,7,0,3,4,4,0};

            string resultado = ClassISBN2.VerifyISBN(ISBN);

            Assert.AreEqual("ISBN VALIDO", resultado);

        }
    }
}

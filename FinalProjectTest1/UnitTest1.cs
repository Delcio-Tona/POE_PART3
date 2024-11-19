using NUnit.Framework;
namespace FinalProjectTest1
    
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
            string username = "Admin", password = "admin";
            testinFunctionalities user = new testinFunctionalities();
            Assert.AreEqual(true, user.Login(username, password));
            //Assert.Pass(username);
        }
        [Test]
        public void Test2()
        {
            
            testinFunctionalities user = new testinFunctionalities();
            Assert.AreEqual(true, user.Approval("Approved"));
            //Assert.Pass(username);
        }

        [Test]
        public void Test3()
        {

            testinFunctionalities user = new testinFunctionalities();
            Assert.AreEqual(true, user.Claim("Delcio"));
            //Assert.Pass(username);
        }
    }
}
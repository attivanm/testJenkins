using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.Components;
using TestProject.Steps;

namespace TestProject.Tests
{
    [TestClass]
    public class FirstDemoTest: Hook
    {
        [TestMethod]
        public void FirstTest()
        {
            string message = ContactUsSendMessage.Run();
            Assert.AreEqual("Your message has been successfully sent to our team.", message);
        }
    }
}

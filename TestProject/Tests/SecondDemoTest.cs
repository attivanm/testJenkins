using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.Components;
using TestProject.Steps;

namespace TestProject.Tests
{
    [TestClass]
    public class SecondDemoTest: Hook
    {
        [TestMethod]
        public void FirstTestTitle()
        {
            string message = ContactUsSendMessage.Run();
            Assert.AreEqual("Your message has been successfully sent to our team.", message);
        }
        [TestMethod]
        public void SecondTestTitle()
        {
            string message = ContactUsSendMessage.Run();
            Assert.AreEqual("Your message has been successfully sent to our team.", message);
        }
        [TestMethod]
        public void ThirdTestTitle()
        {
            string message = ContactUsSendMessage.Run();
            Assert.AreEqual("Your message has been successfully sent to our team.", message);
        }
    }
}

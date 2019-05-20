using Framework.Initializer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Components
{
    [TestClass]
    public class Hook: InitializerHook
    {
        //public Hook()
        //{

        //}

        [ClassInitialize]
        public void SetupClass()
        {
            
        }

        [TestInitialize]
        public void Setup()
        {
            OpenBrowser();
        }

        [TestCleanup]
        public void TearDown()
        {
            CloseBrowser();
        }

        [ClassCleanup]
        public void TearDownClass()
        {

        }
    }
}

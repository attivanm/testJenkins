using OpenQA.Selenium;

namespace Framework.Base
{
    public class BaseDriver
    {
        private static IWebDriver Driver;
        public static BasePage CurrentPage;

        public static IWebDriver GetDriver()
        {
            return Driver;
            //return _driver;
        }

        public static void SetDriver(IWebDriver driver)
        {
            //_driver = driver;
            Driver = driver;
        }

    }
}

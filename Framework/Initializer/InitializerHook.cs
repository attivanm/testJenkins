using Framework.Base;
using OpenQA.Selenium.Chrome;

namespace Framework.Initializer
{
    public class InitializerHook: BaseDriver
    {
        protected static void OpenBrowser()
        {
            string browserType = "Chrome";

            //string chromePath = "";

            switch (browserType)
            {
                case "Chrome":
                    var webdriverlocation = @"C:\Selenium\WebDrivers";
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--start-maximized");
                    SetDriver(new ChromeDriver(webdriverlocation,options));
                    break;
                case "Firefox":
                    break;
            }
        }

        protected static void CloseBrowser()
        {
            GetDriver().Close();
            GetDriver().Quit();
        }        
    }
}

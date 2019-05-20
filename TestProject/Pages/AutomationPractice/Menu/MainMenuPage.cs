using Framework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject.Pages.AutomationPractice.Menu
{
    public class MainMenuPage: BasePage
    {
        // [FindsBy(How = How.XPath,Using = "//div/a[@title='Contact Us']")]
        private IWebElement contactUsButton => GetDriver().FindElement(By.XPath("//div/a[@title='Contact Us']"));
        private IWebElement loginButton => GetDriver().FindElement(By.XPath("//a[@class='login']"));

        private IWebElement GetloginButton()
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(loginButton));                
            return loginButton;
        }

        private IWebElement GetContactUsButton()
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(contactUsButton));
            return contactUsButton;
        }

        #region keyword

        public void ClickContactUsbutton()
        {
            GetContactUsButton().Click();
        }

        #endregion

    }
}

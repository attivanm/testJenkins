namespace Framework.Base
{
    public class BaseStep: BaseDriver
    {
        public static void NavigateToSite()
        {
            GetDriver().Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
    }
}

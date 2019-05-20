using Framework.Base;
using TestProject.Pages.AutomationPractice;

namespace TestProject.Steps
{
    public class ContactUsSendMessage: BaseStep
    {
        public static string Run()
        {
            NavigateToSite();
            var CurrentPage1 = new HomePage().GetInstance3<HomePage>();
            CurrentPage1.As<HomePage>().ClickContactUsbutton();

            var CurrentPage2 = new ContactUsPage().GetInstance3<ContactUsPage>();
            CurrentPage2.As<ContactUsPage>().FillContactUsForm("Customer service", "daniel.terceros.b@gmail.com", "123",@"C:\Test.txt", "message 123");

            return CurrentPage2.As<ContactUsPage>().getConfirmationMessageText();
        }
    }
}

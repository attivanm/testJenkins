using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestProject.Pages.AutomationPractice.Menu;

namespace TestProject.Pages.AutomationPractice
{
    public class ContactUsPage: MainMenuPage
    {
        private IWebElement subjectHeadingDropDown => GetDriver().FindElement(By.Id("id_contact"));
        private IWebElement emailAddressField => GetDriver().FindElement(By.Id("email"));        
        private IWebElement orderReferenceField => GetDriver().FindElement(By.Id("id_order"));
        private IWebElement attachmentInput => GetDriver().FindElement(By.Id("fileUpload"));
        private IWebElement messageInput => GetDriver().FindElement(By.Id("message"));
        private IWebElement sendButton => GetDriver().FindElement(By.Id("submitMessage"));
        private IWebElement confirmationMessage => GetDriver().FindElement(By.XPath("//p[@class='alert alert-success']"));

        #region flow control
        private IWebElement getSubjectHeadingDropDown()
        {            
            return subjectHeadingDropDown;
        }

        private IWebElement getEmailAddressField()
        {
            return emailAddressField;
        }

        private IWebElement getOrderReferenceField()
        {
            return orderReferenceField;
        }

        private IWebElement getAttachmentInput()
        {
            return attachmentInput;
        }

        private IWebElement getMessageInput()
        {
            return messageInput;
        }

        private IWebElement getSendButton()
        {
            return sendButton;
        }

        private IWebElement getConfirmationMessage()
        {
            return confirmationMessage;
        }

        #endregion

        #region interaction

        private void selectItemsInSubjectheading(string value, string by)
        {
            Select = new SelectElement(subjectHeadingDropDown);
            switch (by.ToLower())
            {
                case "visible text":
                    Select.SelectByText(value);
                    break;
                case "value":
                    Select.SelectByValue(value);
                    break;
                case "index":
                    Select.SelectByIndex(int.Parse(value));
                    break;
            }
        }

        private void insertEmailAddress(string email)
        {            
            getEmailAddressField().SendKeys(email);
        }

        private void insertOrderReference(string orderReference)
        {
            getOrderReferenceField().SendKeys(orderReference);
        }

        private void insertAttachFile(string filePath)
        {
            getAttachmentInput().SendKeys(filePath);
        }

        private void insertMessage(string message)
        {
            getMessageInput().SendKeys(message);
        }

        private void clickSendButton()
        {
            getSendButton().Click();
        }
        #endregion
     
        public string getConfirmationMessageText()
        {
            return getConfirmationMessage().Text;
        }

        public void FillContactUsForm(string subjectHeading, string emailAddress, string orderReference, string attachFile, string message)
        {
            selectItemsInSubjectheading(subjectHeading, "visible text");
            insertEmailAddress(emailAddress);
            insertOrderReference(orderReference);
            insertAttachFile(attachFile);
            insertMessage(message);
            clickSendButton();          
        }
       
    }
}

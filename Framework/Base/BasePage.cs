using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Base
{
    public class BasePage : BaseDriver
    {
        public static WebDriverWait Wait;
        public static Actions Actions;
        public static SelectElement Select;

        public BasePage()
        {
            Wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(30));
            Actions = new Actions(GetDriver());
        }

        #region
        //public TPage getInstance<TPage, extends, BasePage>(Class<TPage> page)
        //{
        //    //Object obj = new p
        //    return (TPage)Activator.CreateInstance(typeof(TPage), new object[] { page });
        //}

        public static TPage GetInstance<TPage, extends, BasePage>(TPage page)
        {
            //Object obj = new p
            return (TPage)Activator.CreateInstance(typeof(TPage), new object[] { page });
            // return (TPage)Activator.CreateInstance(typeof(TPage), page);
        }

        public static TPage GetInstance2<TPage>(TPage page) where TPage : BasePage, new()
        {
            return (TPage)Activator.CreateInstance(typeof(TPage), page);
        }



        //public T GetInstance4<T>(string firstName, string lastName) where T : BasePage, new()
        //{
        //    T obj = new T();
        //    return obj;
        //}

        #endregion


        public TPage GetInstance3<TPage>() where TPage : BasePage, new()
        {
            TPage page = new TPage();
            return page;           
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }

        public void click()
        {
            ///
        }

    }
}

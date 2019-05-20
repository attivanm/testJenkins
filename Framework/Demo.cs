using Framework.Base;
using Framework.Initializer;
using System;

namespace Framework
{
    public class Demo: BaseStep
    {
        public static void Main()
        {
            //InitializerHook.OpenBrowser();
            //NavigateToSite();

            string a = "name";

            Console.WriteLine($"The name is {a}");
            Console.ReadKey();
        }
    }
}

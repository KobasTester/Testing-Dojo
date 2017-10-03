using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice
{
    public class MainPage
    {
        static IWebDriver driver = new ChromeDriver();

        public static void GoTo(string url)
        {
            driver.Url = url;
        }

        public static bool Loaded()
        {
            throw new NotImplementedException();
        }
    }
}

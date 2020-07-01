using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealsiwantRepo.Pages.GUser
{
    class GUserSignInPage : Baseclass
    {
        IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//h2")]
        public IWebElement Register;

        [Obsolete]
        public GUserSignInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public string GSigninPageheading()
        {
            String RegisterText = Register.Text;
            return RegisterText;
        }
    }
}

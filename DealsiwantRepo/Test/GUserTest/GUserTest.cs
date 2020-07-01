using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealsiwantRepo.Test.GUserTest
{
    class GUserTest : Baseclass
    {
       
        [Test]
        [Obsolete]
        public void GHomePageTest()
        {
            test = extent.StartTest("GHomePageTest");

            //GenericUserMenus Methods
            GUM.GHomeMenu();
           // GUserHomePage GUHP = new GUserHomePage(driver);
            //GenericUserHomePage Method
            GUHP.GCityTextbox();
            String actual = GUHP.GCityTextbox();
            Console.WriteLine(actual);
            Assert.AreEqual(actual, "City : Chennai");
            GUM.GAboutUsMenu();
            GUM.GSignIn();

            //GenericUserSignInPage Methods
            String actual1 = GUSIP.GSigninPageheading();
            Console.WriteLine(actual1);
            Assert.AreEqual(actual1, "Regissster");
            test.Log(LogStatus.Pass, "Test Passed");
        }


        static void Main(string[] args)
        {

        }
    }
}

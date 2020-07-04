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

            //GUserMenus Methods
            GUM.GHomeMenu();
           
            //GUserHomePage Method
            GUHP.GCityTextbox();
            String actual = GUHP.GCityTextbox();
            Console.WriteLine(actual);
            Assert.AreEqual(actual, "City : Chennai");
            GUM.GAboutUsMenu();
            GUM.GSignIn();

            //GUserSignInPage Methods
            String actual1 = GUSIP.GSigninPageheading();
            Console.WriteLine(actual1);
            Assert.AreEqual(actual1, "Register");
            test.Log(LogStatus.Pass, "Test Passed");
            GUSIP.GSigninRegisterTextboxs("Deepa", "deeps@gmail.com", "D1i2y3a4", "123456789");
            
            


            //GUSIP.GSignupExcelInput();
        }


        static void Main(string[] args)
        {

        }
    }
}

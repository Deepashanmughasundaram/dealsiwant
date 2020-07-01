using DealsiwantRepo.Pages.GUser;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using System;

namespace DealsiwantRepo
{
    class Baseclass
    {
        public IWebDriver driver;
        public static ExtentReports extent;
        public static ExtentTest test;
        public GUserMenus GUM;
        public GUserSignInPage GUSIP;
        public GUserHomePage GUHP;

        [OneTimeSetUp]
        [System.Obsolete]
        public void Setup()
        {
            //Append the html report file to current project path
            string reportPath = "C:\\Users\\deepa\\source\\repos\\NUnitProject\\Reports\\TestRunReport.html";
            //Boolean value for replacing exisisting report
            extent = new ExtentReports(reportPath, true);
            //Add QA system info to html report
            extent.AddSystemInfo("Host Name", "YourHostName").AddSystemInfo("Environment", "YourQAEnvironment").AddSystemInfo("Username", "YourUserName");
            //Adding config.xml file
            extent.LoadConfig("extent.config.xml"); //Get the config.xml file from http://extentreports.com


            driver = new ChromeDriver();
            driver.Url = "http://localhost/product/";


            GUM = new GUserMenus(driver);
            GUSIP = new GUserSignInPage(driver);
            GUHP = new GUserHomePage(driver);
        }


        [TearDown]
        public void AfterClass()
        {
            //StackTrace details for failed Testcases
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "" + TestContext.CurrentContext.Result.StackTrace + "";
            var errorMessage = TestContext.CurrentContext.Result.Message;
            if (status == TestStatus.Failed)
            {
                string currentDate = DateTime.Now.ToString("HH:mm:ss");
                var image = ((ITakesScreenshot)driver).GetScreenshot();
                //Save the screenshot
                image.SaveAsFile("C:\\Users\\deepa\\source\\repos\\DealsiwantRepo\\Failed SS\\" + currentDate + ".png", ScreenshotImageFormat.Png);
                test.Log(LogStatus.Fail, status + errorMessage);
            }
        }

            [OneTimeTearDown]
            public void Teardown()
            {
                driver.Quit();

                //End Report
                extent.Flush();
                extent.Close();
            }

        }
    }


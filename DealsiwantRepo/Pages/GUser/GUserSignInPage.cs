using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;

namespace DealsiwantRepo.Pages.GUser
{
    class GUserSignInPage : Baseclass
    {
        IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//h2")]
        public IWebElement Register;
      
        [FindsBy(How = How.XPath, Using = "(//input[@class='inpt'])[1]")]
        public IWebElement GSignUpRegisterNameTB;

        [FindsBy(How = How.XPath, Using = "(//input[@class='inpt'])[2]")]
        public IWebElement GSignUpRegisterEmailIDTB;
        [FindsBy(How = How.XPath, Using = "(//div[@class='bill_row'])[3]/span/../label")]
        public IWebElement GSignUpRegisterEmailIDErrorMsg;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bill_row'])[4]/span/../input")]
        public IWebElement GSignUpRegisterPasswordTB;
        [FindsBy(How = How.XPath, Using = "(//div[@class='bill_row'])[4]/span/../label")]
        public IWebElement GSignUpRegisterPasswordErrorMsg;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bill_row'])[5]/span/../input")]
        public IWebElement GSignUpRegisterMobileTB;
        [FindsBy(How = How.XPath, Using = "(//div[@class='bill_row'])[5]/span/../label")]
        public IWebElement GSignUpRegisterMobileErrorMsg;

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement GSubmitButton;
        [FindsBy(How = How.XPath, Using = "//span[@style='color:#6600FF']/text()")]
        public IWebElement GSuccessfulRegistrationMsg;

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

        public void GSigninRegisterTextboxs(String NameTB, String EmailTB, String PasswordTB, String MobileTB)
        {
            GSignUpRegisterNameTB.SendKeys(NameTB);
            GSignUpRegisterEmailIDTB.SendKeys(EmailTB);            
            Thread.Sleep(1000);           
            GSignUpRegisterPasswordTB.SendKeys(PasswordTB);
            Thread.Sleep(1000);
            GSignUpRegisterMobileTB.SendKeys(MobileTB);
            GSubmitButton.Click();
/*            string EmailErrorMsg = GSignUpRegisterEmailIDErrorMsg.Text;
            if (EmailErrorMsg.Equals("deeps.smkd@gmail.com is already in use"))
            {
                Console.WriteLine("Try Different Email ID");
            }
            else 
            {
                bool PasswordErrorMsg = GSignUpRegisterPasswordErrorMsg.Displayed;
                Console.WriteLine("Try Different Password");
            } 
            bool MobileErrorMsg = GSignUpRegisterMobileErrorMsg.Displayed;
            

            String SuccessMsg = GSuccessfulRegistrationMsg.Text;
            Console.WriteLine(SuccessMsg);           
*/        }


        /*        public void GSignupExcelInput()
                {
                    [FindsBy(How = How.XPath, Using = "(//input[@class='inpt'])[1]")]
                    public IWebElement GSignUpNameTB;
                    //Create COM Objects. Create a COM object for everything that is referenced
                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\deepa\source\repos\DealsiwantRepo\DealsiwantRepo\Excel\DataRef.xlsx");
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;

                    int rowCount = xlRange.Rows.Count;
                    int colCount = xlRange.Columns.Count;

                    //iterate over the rows and columns and print to the console as it appears in the file
                    //excel is not zero based!!
                    for (int i = 1; i <= rowCount; i++)
                    {
                        for (int j = 1; j <= colCount; j++)
                        {
                            //new line
                            if (j == 1)
                                Console.Write("\r\n");

                            //write the value to the console
                            if (j == 1)
                            {
                                if (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null)
                                    Console.WriteLine(xlRange.Cells[i, 1].Value2.ToString());
                                GSignUpNameTB.SendKeys(xlRange.Cells[i, 1].Value2.ToString());
                            }
                        }
                    }

                    //cleanup
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    //rule of thumb for releasing com objects:
                    //  never use two dots, all COM objects must be referenced and released individually
                    //  ex: [somthing].[something].[something] is bad

                    //release com objects to fully kill excel process from running in the background
                    Marshal.ReleaseComObject(xlRange);
                    Marshal.ReleaseComObject(xlWorksheet);

                    //close and release
                    xlWorkbook.Close();
                    Marshal.ReleaseComObject(xlWorkbook);

                    //quit and release
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);
                }
        */
    }

}

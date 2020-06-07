using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Task9_DropDown
{
    [TestClass]
    public class DropDown
    {

        IWebDriver driver = new ChromeDriver();

        //this works before execution of every test of this class
        [TestInitialize]
        public void Initilize()
        {
            //set url of driver 
            driver.Url = "https://www.google.com/";

            //maximize browser as well
            driver.Manage().Window.Maximize();

            //set implicit time wait as well ( which stays for entire session) 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TestMethod]
        public void TestMethod1()
        { 
            try
            {
                //finding element with the Name "q" and entering "GeeksForGeeks" there, after that enter is pressed (keyboard)
                driver.FindElement(By.Name("q")).SendKeys("GeeksForGeeks" + Keys.Enter);
                Console.WriteLine("1 - Searched 'GeeksForGeeks'");

                //finding element with the ClassName "r" and clicking it
                driver.FindElement(By.ClassName("r")).Click();
                Console.WriteLine("2 - Clicking 'GeeksForGeeks' website link");

                //find element with id mentioned and click it
                driver.FindElement(By.Id("menu-item-351946")).Click();
                Console.WriteLine("3 - Clicked Tutorials");

                //find element with id mentioned and click it
                driver.FindElement(By.Id("menu-item-351977")).Click();
                Console.WriteLine("4 - Clicked Sub Part of it");

                //find element with id mentioned and click it
                driver.FindElement(By.Id("menu-item-362995")).Click();
                Console.WriteLine("5 - Clicked Super Sub Part of it");

                //title is which appears on the tab
                //Console.WriteLine(driver.Title);

                //assert
                Assert.AreEqual(driver.Title, "Stack Data Structure - GeeksforGeeks");

                Console.WriteLine("6 - Success!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured : " + e);
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            //close the browser
            driver.Close();

            //most important step
            driver.Quit();
        }
    }
}

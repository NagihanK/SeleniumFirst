using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
	class Program
	{
		static void Main(string[] args)
		{

		}
		// create the ref or browser
		IWebDriver driver = new ChromeDriver();

		[SetUp]
		public void Initiliaze() {


			// navigate google page 
			driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=hazel+&Password=&Login=Login");

			Console.WriteLine("Opened URL");
		}

		[Test]
		public void TestExecute()
		{
			/*IWebElement element = driver.FindElement(By.Name("q"));

			//perform ops
			element.SendKeys("course");
			Console.WriteLine("Executed Test"); */



			//select title with drop down with calling dropdown method :
			SeleniumSetMethod.selectDropDown(driver, "TitleId", "Mr.", "Id");
			//initial box :
			SeleniumSetMethod.EnterText(driver, "Initial", "executeautomation", "Name");
		   //click 
		   SeleniumSetMethod.clickmethod(driver , "Save" , "Name");


		}
		[TearDown]
		public void CleanUp()
		{
			driver.Close();
			Console.WriteLine("close the browser");
		}
	

	}
}

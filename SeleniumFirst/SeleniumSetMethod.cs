using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumSetMethod 
    {

        //simple generric method 

        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {

            //driver instance lazim oyuzden method parameter olarak ekleyecegiz |
            //
            if (elementType == "id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == "LinkText")
                driver.FindElement(By.Name(element)).SendKeys(value);

        }

        //click icin method : 

        public static void clickmethod(IWebDriver driver, string element, string elementType)
        {

            if (elementType == "id")
                driver.FindElement(By.Id(element)).Click();
            if (elementType == "LinkText")
                driver.FindElement(By.Name(element)).Click();

        }

        // selecting dropdown method 

        public static void selectDropDown(IWebDriver driver, string element, string elementType, string v)
        {

            // SelectElement select = new SelectElement() --> bunu boyle yazacagina if icine atio new selelectElement die  cunku paremeter de sorun oluo 

            if (elementType == "id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == "LinkText")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);

        }
    }
}
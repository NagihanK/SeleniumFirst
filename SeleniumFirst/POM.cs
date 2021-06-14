using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFirst
{
    class POM
    {
        public POM()
        {
            PageFactory.InitElements(SeleniumFirst.PropertiesCollection.driver, this);

        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement TitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }


        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }


        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement buttonSave { get; set; }



        //login method need to fill the form 
        public void FillUserForm(string intial, string middleName, string firstname) {
            txtInitial.SendKeys(intial);
            txtFirstName.SendKeys(firstname);
            txtMiddleName.SendKeys(middleName);
            buttonSave.Click();
        
        }

    }
}
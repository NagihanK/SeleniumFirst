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

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement buttonSave { get; set; }
        public object PropertiesCollection { get; private set; }
    }
}

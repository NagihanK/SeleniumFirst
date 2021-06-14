using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFirst
{
    class LoginPageObj
    {

        public LoginPageObj()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this); 


        }


        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement bttnLogin { get; set; }


        //login mthod
        public POM  Login(string username, string password) {
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
            bttnLogin.Submit();

            return new POM();

        }


    }
}

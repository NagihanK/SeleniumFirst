using System;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumF2
{
    internal class FindsByAttribute : Attribute
    {
        public How How;

        public string Using { get; set; }
    }
}
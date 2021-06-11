using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumFirst{

    enum PropertyType
    {
        Id,
        Name,
        CssNAme,
        ClassName
    }


    class PropertiesCollection
    {
        //Auto implemented properties
        public static IWebDriver driver { get; set; }

    }
}

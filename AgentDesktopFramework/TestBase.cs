using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AgentDesktopFramework
{
    public class TestBase
    {
        public IWebDriver WebDriver { get; set; }

        private static List<string> RequiredCookies => new List<string>
        {
            "CMSPOD",
            "RBKPOD",
            "cookies.js",
            "idb*",
            "lang2012",
            "odb*",
            "sc.ASP.NET_SESSIONID",
            "sc.Status"
        };

    }
}

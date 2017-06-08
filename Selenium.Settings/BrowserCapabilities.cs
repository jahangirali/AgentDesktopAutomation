using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Settings
{
    public static class BrowserCapabilities
    {
        public static DesiredCapabilities GetChromeSettings
        {
            get
            {
                var options = new ChromeOptions():
                options.AddArguments("--test-type");
                options.AddArguments("--disable-extensions");
                return options.ToCapabilities() as DisiredCapabilities;
            }
        }
    }
}

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
                return options.ToCapabilities() as DesiredCapabilities;
            }
        }

        public static DesiredCapabilities GetFirefoxSettings => new DesiredCapabilities().Firefox();

        public static DesiredCapabilities GetInternetExplorerSettings
        {
            get
            {
                var caps = DesiredCapabilities.InternetExplorer();
                caps.SetCapability("nativeEvents", true);
                return caps;
            }
        }
    }
}

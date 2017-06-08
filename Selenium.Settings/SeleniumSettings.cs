using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Settings
{
    public static class SeleniumSettings
    {
        public static string SystemUnderTest { get; set; } =
            Environment.GetEnvironmentVariable("SystemUnderTest") ?? "http://easyjet.com";

        public static String Browser { get; set; } = Environment.GetEnvironmentVariable("Browser") ?? "chrome";
    }
}

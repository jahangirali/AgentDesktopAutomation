using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Settings
{
    public class Timeouts
    {
        public static int ControlTimeout => Convert.ToInt32(Environment.GetEnvironmentVariable("ControlTimeout") ?? "30");

        public static int PageLoadTimeout { get; set; } =
            Convert.ToInt32(Environment.GetEnvironmentVariable("PageLoadTimeout") ?? "30");
    }
}

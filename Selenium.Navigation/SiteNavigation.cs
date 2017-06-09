using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Navigation
{
    public static class SiteNavigation
    {
        public static PickFlight GetToPickFlightsPage(RequestedFlight requestedFlight, IWebDriver driver)
        {
            var homePage = new Home(driver);
            return homePage.SearchPod.SearchForFlights();
        }
    }
}

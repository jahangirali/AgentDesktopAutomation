using System;

namespace Selenium.Pages.Exceptions
{
    public class PageNotFoundException : Exception
    {
        public PageNotFoundException(string exception) : base(exception)
        {
        }
    }
}


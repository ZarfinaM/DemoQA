using DemoQa;
using OpenQA.Selenium;

namespace DemoQA.AlertsMenu
{
    public static class AlertsMenuSteps
    {

        public static void AlertsMenu()
        {
            var alertsMenu = Driver.Instance.FindElement(By.CssSelector("#app > div > div > div.home-body > div > div:nth-child(3)"));
            alertsMenu.Click();
        }

        public static void ItemAlerts()
        {
            var itemAlerts = Driver.Instance.FindElement(By.CssSelector("body > div:nth-child(6) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(3) > div:nth-child(2) > ul:nth-child(1) > li:nth-child(2)"));
            itemAlerts.Click();
        }

        public static void ButtonSeeAllert()
        {
            var buttonSeeALert = Driver.Instance.FindElement(By.CssSelector("#alertButton"));
            buttonSeeALert.Click();
            Driver.Instance.SwitchTo().Alert().Accept();
        }

        public static void ButtonConfirmBox()
        {
            var buttonConfirmBox = Driver.Instance.FindElement(By.CssSelector("#confirmButton"));
            buttonConfirmBox.Click();
        }


        
        
    }
}

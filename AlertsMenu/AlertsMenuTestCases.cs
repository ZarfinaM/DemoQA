using DemoQA.AlertsMenu;
using DemoQA.CommonStepsDemoQa;
using DemoQA.ElementsMenu;

namespace DemoQA
{
    public class AlertsMenuTestCases
    {
        public static string ClickButtonToSeeAlert()
        {
            string message = "";
            string clickButtonToSeeAlertMessage = "";


            try
            {
                CommonSteps.GoogleSearchDemoQa();
                CommonSteps.DemoQa();
                AlertsMenuSteps.AlertsMenu();
                AlertsMenuSteps.ItemAlerts();
                AlertsMenuSteps.ButtonSeeAllert();

            }

            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += clickButtonToSeeAlertMessage;
            return message;

        }
    }
}
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
                CommonSteps.AcceptAlarm();

            }

            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += clickButtonToSeeAlertMessage;
            return message;

        }

        public static string ConfirmBoxAccept()
        {
            string message = "";
            string confirmBoxAcceptMessage = "";


            try
            {
                CommonSteps.GoogleSearchDemoQa();
                CommonSteps.DemoQa();
                AlertsMenuSteps.AlertsMenu();
                AlertsMenuSteps.ItemAlerts();
                AlertsMenuSteps.ButtonConfirmBox();
                CommonSteps.AcceptAlarm();


            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += confirmBoxAcceptMessage;
            return message;

        }
    }
}
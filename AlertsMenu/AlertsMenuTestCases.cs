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

        public static string ConfirmBoxDismiss()
        {
            string message = "";
            string confirmBoxDismissMessage = "";


            try
            {             
                AlertsMenuSteps.AlertsMenu();
                AlertsMenuSteps.ItemAlerts();
                AlertsMenuSteps.ButtonConfirmBox();
                CommonSteps.DismissAlarm();

            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += confirmBoxDismissMessage;
            return message;

        }

       public static string PromptBox()
        {
            string message = "";
            string promptBoxMessage = "";


            try
            {              
                AlertsMenuSteps.AlertsMenu();
                AlertsMenuSteps.ItemAlerts();
                AlertsMenuSteps.PromptBoxButton();
                CommonSteps.PromptBoxText();
                
                

            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += promptBoxMessage;
            return message;

        }
    }
}
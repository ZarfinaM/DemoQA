using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DemoQa;
using DemoQA.CommonStepsDemoQa;
using DemoQA.InteractionsMenu;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DemoQA
{
    public class InteractionsMenuTestCases
    {
        public static string DragAndDrop()
        {
            string message = "";
            string dragAndDropMessage = "";


            try
            {
                CommonSteps.GoogleSearchDemoQa();
                CommonSteps.DemoQa();
                InteractionsMenuSteps.InteractionsMenu();
                InteractionsMenuSteps.Droppable();
                InteractionsMenuSteps.DragAndDropSimple();

            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += dragAndDropMessage;
            return message;

        }
    }
}
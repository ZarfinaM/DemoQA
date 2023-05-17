using DemoQa;
using DemoQA;
using DemoQA.FormsMenu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DemoQa
{
    [TestClass]
    public class Alerts
    {
        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();

            int a = int.Parse(parameters.browser);

            Driver.Initialize(a);
        }

        [TestMethod]
        public void TestCaseClickButtonToSeeAlert()
        {
            string subject = "",
                     body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string clickButtonToSeeAlertMessage = AlertsMenuTestCases.ClickButtonToSeeAlert();

            if (!clickButtonToSeeAlertMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + clickButtonToSeeAlertMessage;
            }
            else
            {
                subject = "Failed!!" + subject;
                body = clickButtonToSeeAlertMessage;
            }
        }
        [TestMethod]
        public void TestCaseConfirmBoxAccept()
        {
            string subject = "",
                     body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string confirmBoxAcceptMessage = AlertsMenuTestCases.ConfirmBoxAccept();

            if (!confirmBoxAcceptMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + confirmBoxAcceptMessage;
            }
            else
            {
                subject = "Failed!!" + subject;
                body = confirmBoxAcceptMessage;
            }


        }


        [TestCleanup]
        public void Cleanup()

        {
            Driver.Close();

        }

    }
}
    

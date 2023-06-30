using DemoQa;
using DemoQA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DemoQa
{
    [TestClass]
    public class Elements
    {

        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();

            int a = int.Parse(parameters.browser);

            Driver.Initialize(a);
        }
        [TestMethod]
        public void TestCaseTextBox()
        {
            string subject = "",
                     body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string textBoxMessage = ElementsMenuTestCases.TextBox();

            if (!textBoxMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + textBoxMessage;
            }
            else
            {
                subject = "Failed!!" + subject;
                body = textBoxMessage;
            }

        }

        [TestMethod]
        public void TestCaseRadioButton()
        {
            string subject = "",
                     body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string radioButtonMessage = ElementsMenuTestCases.RadioButton();

            if (!radioButtonMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + radioButtonMessage;
            }
            else
            {
                subject = "Failed!!" + subject;
                body = radioButtonMessage;
            }
        }

        [TestMethod]
        public void TestCaseCheckButton()
        {
            string subject = "",
                     body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string checkBoxMessage = ElementsMenuTestCases.CheckBox();

            if (!checkBoxMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + checkBoxMessage;
            }
            else
            {
                subject = "Failed!!" + subject;
                body = checkBoxMessage;
            }
        }

        [TestMethod]
        public void TestCaseWebTablesFirstNameAsc()
        {
            string subject = "",
                     body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string webTableFirstNameAscMessage = ElementsMenuTestCases.WebTablesFirstNameAsc();

            if (!webTableFirstNameAscMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + webTableFirstNameAscMessage;
            }
            else
            {
                subject = "Failed!!" + subject;
                body = webTableFirstNameAscMessage;
            }
        }

        [TestMethod]
        public void TestCaseWebTablesAldenChangeSalary()
        {
            string subject = "",
                         body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string webTablesAldenChangeSalaryMessage = ElementsMenuTestCases.WebTablesAldenChangeSalary();

            if (!webTablesAldenChangeSalaryMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + webTablesAldenChangeSalaryMessage;
            }
            else
            {
                subject = "Failed!!" + subject;
                body = webTablesAldenChangeSalaryMessage;
            }
        }

        [TestMethod]
        
        public void TestCaseButtonsDoubleClick()
        {
            string subject = "",
                         body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string buttonsDoubleClickMessage = ElementsMenuTestCases.ButtonDoubleClick();

            if (!buttonsDoubleClickMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + buttonsDoubleClickMessage;
            }
            else
            {
                subject = "Failed!!" + subject;
                body = buttonsDoubleClickMessage;
            }
        }

        [TestMethod]

        public void TestCaseButtonRightClick()
        {
            string subject = "",
                         body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string buttonRightClickMessage = ElementsMenuTestCases.ButtonRightClick();

            if (!buttonRightClickMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + buttonRightClickMessage;
            }
            else
            {
                subject = "Failed!!" + subject;
                body = buttonRightClickMessage;
            }
        }

        [TestMethod]

        public void TestCaseUploadImage()

        {
            string subject = "",
                         body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string uploadImageMessage = ElementsMenuTestCases.UploadImage();

            if (!uploadImageMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + uploadImageMessage;
            }
            else
            {
                subject = "Failed!!" + subject;
                body = uploadImageMessage;
            }
        }

        [TestMethod]

        public void TestCaseDownload()

        {
            string subject = "",
                         body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string downloadMessage = ElementsMenuTestCases.Download();

            if (!downloadMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + downloadMessage;
            }
            else
            {
                subject = "Failed!!" + subject;
                body = downloadMessage;
            }
        }



        [TestCleanup]
        public void Cleanup()

        {
            Driver.Close();

        }

    }
}





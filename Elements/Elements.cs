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
                    body = checkBoxMessage;
                }
            }
        }
    }



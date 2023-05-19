using DemoQa;
using DemoQA;
using DemoQA.FormsMenu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DemoQa
{
    [TestClass]
    public class Forms
    {

        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();

            int a = int.Parse(parameters.browser);

            Driver.Initialize(a);
        }
        [TestMethod]
        public void TestCasePracticeForm()
        {
            string subject = "",
                     body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string studentRegistrationPracticeFormMessage = FormsMenuTestCases.StudentRegistrationPracticeForm();

            if (!studentRegistrationPracticeFormMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + studentRegistrationPracticeFormMessage;
            }
            else
            {
                subject = "Failed!!" + subject;
                body = studentRegistrationPracticeFormMessage;
            }

        }

        [TestCleanup]
        public void Cleanup()

        {
            Driver.Close();

        }

    }
}
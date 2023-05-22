using DemoQa;
using DemoQA;
using DemoQA.FormsMenu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DemoQa
{
    [TestClass]
    public class Widgets
    {

        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();

            int a = int.Parse(parameters.browser);

            Driver.Initialize(a);
        }
        [TestMethod]

        public void TestCaseSlider()
        {
            string subject = "",
                     body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string sliderUpToMessage = WidgetsMenuTestCases.SliderUpTo();

            if (!sliderUpToMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + sliderUpToMessage;
            }
            else
            {
                subject = "Failed!!" + subject;
                body = sliderUpToMessage;
            }

        }

        [TestCleanup]
        public void Cleanup()

        {
            Driver.Close();

        }

    }
}
using DemoQa;
using DemoQA;
using DemoQA.FormsMenu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DemoQa
{
    [TestClass]
    public class Interactions
    {
        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();

            int a = int.Parse(parameters.browser);

            Driver.Initialize(a);
        }

        [TestMethod]

        public void TestCaseDragAndDrop()
        {
            string subject = "",
                     body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string dragAndDropMessage = InteractionsMenuTestCases.DragAndDrop();

            if (!dragAndDropMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + dragAndDropMessage;
            }
            else
            {
                subject = "Failed!!" + subject;
                body = dragAndDropMessage;
            }

        }

        [TestCleanup]
        public void Cleanup()

        {
            Driver.Close();

        }

    }
}
    

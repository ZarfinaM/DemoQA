using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQa;
using OpenQA.Selenium;

namespace DemoQA.CommonStepsDemoQa

{
    public static class CommonSteps
    {      

        public static void Email()
        {
            var email = Driver.Instance.FindElement(By.CssSelector("#userEmail"));
            email.Click();
            email.SendKeys("zarfina.mulalic@gmail.com");
        }

        public static void CurrentAddress()
        {
            var currentAddress = Driver.Instance.FindElement(By.CssSelector("#currentAddress"));
            currentAddress.Click();
            currentAddress.SendKeys("Sarajevo");
        }

        public static void SubmitButton()
        {
            var submitButton = Driver.Instance.FindElement(By.Id("submit"));
            submitButton.Click();
        }

        public static void UploadChooseImage()
        {
            var uploadInput = Driver.Instance.FindElement(By.XPath("//input[@id='uploadFile']"));
            uploadInput.SendKeys(@"C:\Users\zary_\OneDrive\Radna površina\Cvijet - Test.jpg");

        }

        public static void AcceptAlarm()
        {
            Driver.Instance.SwitchTo().Alert().Accept();
        }

        public static void DismissAlarm()
        {
            Driver.Instance.SwitchTo().Alert().Dismiss();
        }

        public static void PromptBoxText()
        {
         IAlert promptAlert = Driver.Instance.SwitchTo().Alert();
            promptAlert.SendKeys("QaTest");
            promptAlert.Accept();      

        }
    }
}

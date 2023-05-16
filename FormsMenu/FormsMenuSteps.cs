using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQa;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoQA.Forms
{
    public static class FormsMenuSteps
    {

        public static void FormsMenu()
        {
            var formsMenu = Driver.Instance.FindElement(By.CssSelector("#app > div > div > div.home-body > div > div:nth-child(2)"));
            formsMenu.Click();
        }

        public static void PracticeForm()
        {
            var practiceForm = Driver.Instance.FindElement(By.CssSelector("#app > div > div > div.row > div:nth-child(1) > div > div > div:nth-child(2) > div > ul"));
            practiceForm.Click();

        }

        public static void PracticeFormFirstName()
        {
            var firstName = Driver.Instance.FindElement(By.CssSelector("#firstName"));
            firstName.Click();
            firstName.SendKeys("Jhon");
        }

        public static void PracticeFormLastName()
        {
            var lastName = Driver.Instance.FindElement(By.CssSelector("#lastName"));
            lastName.Click();
            lastName.SendKeys("Jo");
        }

        public static void PracticeFormGender ()
        {
            var genderMale = Driver.Instance.FindElement(By.CssSelector("#genterWrapper > div.col-md-9.col-sm-12 > div:nth-child(1) > label"));
            genderMale.Click();
        }

        public static void PracticeFormMobileNumber()
        {
            var mobileNumber = Driver.Instance.FindElement(By.CssSelector("#userNumber"));
            mobileNumber.Click();
            mobileNumber.SendKeys("000065111");
        }

        public static void PracticeFormDateOfBirth()
        {
            var dateOfBirth = Driver.Instance.FindElement(By.CssSelector("#dateOfBirthInput"));
            dateOfBirth.Click();
        }

        public static void PracticeForm3August2005()
        {
            var birthDayMonth = Driver.Instance.FindElement(By.XPath("//*[@id=\"dateOfBirth\"]/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[1]"));
            birthDayMonth.Click();
            var birthDayMonthAugust = Driver.Instance.FindElement(By.XPath("//*[@id=\"dateOfBirth\"]/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/select/option[8]"));
            birthDayMonthAugust.Click();
            var birthDayYear = Driver.Instance.FindElement(By.XPath("//*[@id=\"dateOfBirth\"]/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[2]/select"));
            birthDayYear.Click();
            var birthDayYear2005 = Driver.Instance.FindElement(By.XPath("//*[@id=\"dateOfBirth\"]/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[2]/select/option[106]"));
            birthDayYear2005.Click();
            var birthDay3 = Driver.Instance.FindElement(By.XPath("//*[@id=\"dateOfBirth\"]/div[2]/div[2]/div/div/div[2]/div[2]/div[1]/div[4]"));
            birthDay3.Click();
        }

        public static void PracticeFormSubjectsMathematics()
        {
            var practiceFormSubject = Driver.Instance.FindElement(By.XPath("//*[@id=\"subjectsContainer\"]"));
            practiceFormSubject.Click();
            practiceFormSubject.SendKeys("Mathematics");
        }

        public static void PracticeFormHobbiesReading()
        {
            var hobbieReading = Driver.Instance.FindElement(By.CssSelector("#hobbiesWrapper > div.col-md-9.col-sm-12 > div:nth-child(2) > label"));
            hobbieReading.Click();
        }

        public static void PracticeFormState()
        {
            // var practiceFormState = Driver.Instance.FindElement(By.XPath("//*[@id=\"stateCity-wrapper\"]/div[2]"));
            // practiceFormState.Click();

            var practiceFormState = Driver.Instance.FindElement(By.XPath("//*[@id='stateCity-wrapper']/div[2]"));
            practiceFormState.SendKeys(Keys.Enter); 

            var stateHaryana = Driver.Instance.FindElement(By.XPath("//*[@id='state']/div/div[1]/div[1]"));
            stateHaryana.Click();




        }

        public static void PracticeFormStateHaryana()
        {
            var stateHaryana = Driver.Instance.FindElement(By.XPath("//*[@id=\"state\"]/div/div[1]/div[1]"));
            stateHaryana.Click();
        }

        public static void PracticeFormCity()
        {
            var practiceFormCity = Driver.Instance.FindElement(By.CssSelector("#state > div > div.css-1hwfws3 > div.css-1uccc91-singleValue"));
            practiceFormCity.Click();
        }

        public static void PracticeFormCityKarnal()
        {
            var cityKarnal = Driver.Instance.FindElement(By.CssSelector("#city > div > div.css-1hwfws3 > div.css-1g6gooi"));
            cityKarnal.Click();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQa;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace DemoQA.FormsMenu
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
            var practiceFormSubject = Driver.Instance.FindElement(By.XPath("//div[@class='subjects-auto-complete__control css-yk16xz-control']"));
            practiceFormSubject.Click();
            practiceFormSubject.SendKeys("English");
        }

        public static void PracticeFormHobbiesReading()
        {
            var hobbieReading = Driver.Instance.FindElement(By.CssSelector("#hobbiesWrapper > div.col-md-9.col-sm-12 > div:nth-child(2) > label"));
            hobbieReading.Click();
        }

        public static void PracticeFormState()
        {
            var practiceFormState = Driver.Instance.FindElement(By.CssSelector("div.body-height:nth-child(2) div.container.playgound-body div.row div.col-12.mt-4.col-md-6:nth-child(2) div.practice-form-wrapper:nth-child(2) form:nth-child(2) div.mt-2.row:nth-child(10) > div.col-md-4.col-sm-12:nth-child(2)"));
            practiceFormState.Click();

        }

        public static void PracticeFormStateHaryana()
        {
           // var stateHaryana = Driver.Instance.FindElement(By.XPath("//div[@id='state']//div[contains(@class,'css-1wy0on6')]"));
           // stateHaryana.Click();

            var stateHaryana = Driver.Instance.FindElement(By.CssSelector("div.body-height:nth-child(2) div.container.playgound-body div.row div.col-12.mt-4.col-md-6:nth-child(2) div.practice-form-wrapper:nth-child(2) div.mt-2.row:nth-child(10) div.col-md-4.col-sm-12:nth-child(2) div.css-2b097c-container div.css-yk16xz-control div.css-1hwfws3 > div.css-1uccc91-singleValue"));
            stateHaryana.Click();
        }

        public static void PracticeFormCity()
        {
            var practiceFormCity = Driver.Instance.FindElement(By.CssSelector("body > div:nth-child(6) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div:nth-child(2) > form:nth-child(2) > div:nth-child(10) > div:nth-child(3)"));
            practiceFormCity.Click();
        }

        public static void PracticeFormCityKarnal()
        {
            var cityKarnal = Driver.Instance.FindElement(By.XPath("//div[contains(text(),'Karnal')]"));
            cityKarnal.Click();
        }
    }

}

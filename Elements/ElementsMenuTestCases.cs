using OpenQA.Selenium;

namespace DemoQa
{
    public class ElementsMenuTestCases
    {
       public static string TextBox()
        {
            string message = "";
            string textBoxMessage = "";


            try
            {
                var googleSearch = Driver.Instance.FindElement(By.Name("q"));
                googleSearch.Click();
                googleSearch.SendKeys("demoqa");
                googleSearch.SendKeys(Keys.Enter);

                var demoQA = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div > div > div > div > div.yuRUbf > a > h3"));
                demoQA.Click();

                var elementsDemoQa = Driver.Instance.FindElement(By.CssSelector("#app > div > div > div.home-body > div > div:nth-child(1)"));
                elementsDemoQa.Click();

                var textBox = Driver.Instance.FindElement(By.CssSelector("#item-0"));
                textBox.Click();

                var textBoxFullName = Driver.Instance.FindElement(By.CssSelector("#userName"));
                textBoxFullName.Click();
                textBoxFullName.SendKeys("Zarfina Mulalic");

                var textBoxEmail = Driver.Instance.FindElement(By.CssSelector("#userEmail"));
                textBoxEmail.Click();
                textBoxEmail.SendKeys("zarfina.mulalic@gmail.com");

                var textBoxCurrentAdrdress = Driver.Instance.FindElement(By.CssSelector("#currentAddress"));
                textBoxCurrentAdrdress.Click();
                textBoxCurrentAdrdress.SendKeys("Sarajevo");

                var textBoxPermanentAddress = Driver.Instance.FindElement(By.CssSelector("#permanentAddress"));
                textBoxPermanentAddress.Click();
                textBoxPermanentAddress.SendKeys("Sarajevo");

                var textBoxSubmit = Driver.Instance.FindElement(By.CssSelector("#submit"));
                textBoxSubmit.Click();

            }

            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += textBoxMessage;
            return message;

        }

        public static string RadioButton()
        {
            string message = "";
            string radioButtonMessage = "";


            try
            {

                var googleSearch = Driver.Instance.FindElement(By.Name("q"));
                googleSearch.Click();
                googleSearch.SendKeys("demoqa");
                googleSearch.SendKeys(Keys.Enter);

                var demoQA = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div > div > div > div > div.yuRUbf > a > h3"));
                demoQA.Click();

                var elementsDemoQa = Driver.Instance.FindElement(By.CssSelector("#app > div > div > div.home-body > div > div:nth-child(1)"));
                elementsDemoQa.Click();

                var radioButton = Driver.Instance.FindElement(By.CssSelector("#item-2"));
                radioButton.Click();

                var radioButtonYes = Driver.Instance.FindElement(By.CssSelector("#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(2) > div:nth-child(2) > label"));
                radioButtonYes.Click();


            }

            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += radioButtonMessage;
            return message;

        }

        public static string CheckBox()
        {
            string message = "";
            string checkBoxMessage = "";


            try
            {
                var googleSearch = Driver.Instance.FindElement(By.Name("q"));
                googleSearch.Click();
                googleSearch.SendKeys("demoqa");
                googleSearch.SendKeys(Keys.Enter);

                var demoQA = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div > div > div > div > div.yuRUbf > a > h3"));
                demoQA.Click();

                var elementsDemoQa = Driver.Instance.FindElement(By.CssSelector("#app > div > div > div.home-body > div > div:nth-child(1)"));
                elementsDemoQa.Click();

                var checkBoxDemoQa = Driver.Instance.FindElement(By.CssSelector("#item-1 > span"));
                checkBoxDemoQa.Click();

                var homeDropDownMenu = Driver.Instance.FindElement(By.CssSelector("#tree-node > ol > li > span > button > svg"));
                homeDropDownMenu.Click();

                var homeDownloadsMenu = Driver.Instance.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(3) > span > button > svg"));
                homeDownloadsMenu.Click();

                var homeDownloadsMenuWordFile = Driver.Instance.FindElement(By.CssSelector("#tree-node > ol > li > ol > li.rct-node.rct-node-parent.rct-node-expanded > ol > li:nth-child(1) > span > label > span.rct-title"));
                homeDownloadsMenuWordFile.Click();

            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += checkBoxMessage;
            return message;

        }

       public static string WebTablesFirstNameAsc()
        {
            throw new NotImplementedException();
        }
    }
    
}
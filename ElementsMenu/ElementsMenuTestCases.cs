using DemoQA.Elements;
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
                ElementsMenuSteps.GoogleSearchDemoQa();
                ElementsMenuSteps.DemoQa();
                ElementsMenuSteps.ElementsMenu();
                ElementsMenuSteps.TextBox();
                ElementsMenuSteps.TextBoxFullName();
                ElementsMenuSteps.TextBoxEmail();
                ElementsMenuSteps.TextBoxCurrentAddress();
                ElementsMenuSteps.TextBoxPermanentAddress();
                ElementsMenuSteps.ElementsSubmitButton();

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

                ElementsMenuSteps.GoogleSearchDemoQa();
                ElementsMenuSteps.DemoQa();
                ElementsMenuSteps.ElementsMenu();
                ElementsMenuSteps.RadioButton();
                ElementsMenuSteps.RadioButtonYes();

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
                ElementsMenuSteps.GoogleSearchDemoQa();
                ElementsMenuSteps.DemoQa();
                ElementsMenuSteps.ElementsMenu();
                ElementsMenuSteps.CheckBox();
                ElementsMenuSteps.CheckBoxHomeDropDownMenu();
                ElementsMenuSteps.CheckBoxHomeDownloadsDropDownMenu();
                ElementsMenuSteps.CheckBoxHomeDownloadsDropDownMenuWordFile();

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
            string message = "";
            string webTableFirstNameAscMessage = "";


            try
            {
                ElementsMenuSteps.GoogleSearchDemoQa();
                ElementsMenuSteps.DemoQa();
                ElementsMenuSteps.ElementsMenu();
                ElementsMenuSteps.WebTables();
                ElementsMenuSteps.WebTablesFirstNameColumn();

            }

            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += webTableFirstNameAscMessage;
            return message;

        }

        public static string WebTablesAldenChangeSalary()
        {
            string message = "";
            string webTablesAldenChangeSalaryMessage = "";


            try
            {
                ElementsMenuSteps.GoogleSearchDemoQa();
                ElementsMenuSteps.DemoQa();
                ElementsMenuSteps.ElementsMenu();
                ElementsMenuSteps.WebTables();
                ElementsMenuSteps.WebTablesAldenEdit();
                ElementsMenuSteps.WebTablesAldenChangeSalary20000();
                ElementsMenuSteps.ElementsSubmitButton();

            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += webTablesAldenChangeSalaryMessage;
            return message;
        }

        public static string ButtonDoubleClick()
        {
            string message = "";
            string buttonsDoubleClickMessage = "";


            try
            {
                ElementsMenuSteps.GoogleSearchDemoQa();
                ElementsMenuSteps.DemoQa();
                ElementsMenuSteps.ElementsMenu();
                ElementsMenuSteps.Buttons();
                ElementsMenuSteps.ButtonDoubleClick();


            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += buttonsDoubleClickMessage;
            return message;
        }

        public static string ButtonRightClick()
        {
            string message = "";
            string buttonRightClickMessage = "";


            try
            {
                ElementsMenuSteps.GoogleSearchDemoQa();
                ElementsMenuSteps.DemoQa();
                ElementsMenuSteps.ElementsMenu();
                ElementsMenuSteps.Buttons();
                ElementsMenuSteps.ButtonRightClick();


            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += buttonRightClickMessage;
            return message;
        }

        public static string UploadImage()
        {
            string message = "";
            string uploadImageMessage = "";


            try
            {
                ElementsMenuSteps.GoogleSearchDemoQa();
                ElementsMenuSteps.DemoQa();
                ElementsMenuSteps.ElementsMenu();
                ElementsMenuSteps.UploadAndDownload();
                ElementsMenuSteps.UploadChooseFileButton();
                ElementsMenuSteps.UploadChooseImage();

            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += uploadImageMessage;
            return message;
        }
    }
}
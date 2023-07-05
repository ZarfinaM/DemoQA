using DemoQA.CommonStepsDemoQa;
using DemoQA.ElementsMenu;
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
               
                ElementsMenuSteps.ElementsMenu();
                ElementsMenuSteps.TextBox();
                ElementsMenuSteps.TextBoxFullName();
                CommonSteps.Email();
                CommonSteps.CurrentAddress();
                ElementsMenuSteps.TextBoxPermanentAddress();
                CommonSteps.SubmitButton();

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
                
                ElementsMenuSteps.ElementsMenu();
                ElementsMenuSteps.WebTables();
                ElementsMenuSteps.WebTablesAldenEdit();
                ElementsMenuSteps.WebTablesAldenChangeSalary20000();
                CommonSteps.SubmitButton();

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
               
                ElementsMenuSteps.ElementsMenu();
                ElementsMenuSteps.UploadAndDownload();
                CommonSteps.UploadChooseImage();

            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += uploadImageMessage;
            return message;
        }

        public static string Download()
        {
            string message = "";
            string downloadMessage = "";


            try
            {
                
                ElementsMenuSteps.ElementsMenu();
                ElementsMenuSteps.UploadAndDownload();
                ElementsMenuSteps.DownloadButton();
                ElementsMenuSteps.IsDownloadCompleted();

            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += downloadMessage;
            return message;
        }
    }
}
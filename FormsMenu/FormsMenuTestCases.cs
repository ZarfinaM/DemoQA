using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQA.Elements;

namespace DemoQA.Forms
{
    public class FormsMenuTestCases
    {
        public static string StudentRegistrationPracticeForm()
        {
            string message = "";
            string textBoxMessage = "";


            try
            {
                ElementsMenuSteps.GoogleSearchDemoQa();
                ElementsMenuSteps.DemoQa();
                FormsMenuSteps.FormsMenu();
                FormsMenuSteps.PracticeForm();
                FormsMenuSteps.PracticeFormFirstName();
                FormsMenuSteps.PracticeFormLastName();
                ElementsMenuSteps.TextBoxEmail();
                FormsMenuSteps.PracticeFormGender();
                FormsMenuSteps.PracticeFormMobileNumber();
                FormsMenuSteps.PracticeFormDateOfBirth();
                FormsMenuSteps.PracticeForm3August2005();
               // FormsMenuSteps.PracticeFormSubjectsMathematics();
                FormsMenuSteps.PracticeFormHobbiesReading();
                ElementsMenuSteps.UploadChooseImage();
                ElementsMenuSteps.TextBoxCurrentAddress();
                FormsMenuSteps.PracticeFormState();
               // FormsMenuSteps.PracticeFormStateHaryana();
                FormsMenuSteps.PracticeFormCity();
                FormsMenuSteps.PracticeFormCityKarnal();
            }

            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += textBoxMessage;
            return message;

        }
    }
    
}

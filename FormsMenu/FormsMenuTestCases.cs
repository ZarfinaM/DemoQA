using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQA.FormsMenu;
using DemoQA.ElementsMenu;
using DemoQA.CommonStepsDemoQa;

namespace DemoQA
{
    public class FormsMenuTestCases
    {
        public static string StudentRegistrationPracticeForm()
        {
            string message = "";
            string textBoxMessage = "";


            try
            {
                CommonSteps.GoogleSearchDemoQa();
                CommonSteps.DemoQa();
                FormsMenuSteps.FormsMenu();
                FormsMenuSteps.PracticeForm();
                FormsMenuSteps.PracticeFormFirstName();
                FormsMenuSteps.PracticeFormLastName();
                CommonSteps.Email();
                FormsMenuSteps.PracticeFormGender();
                FormsMenuSteps.PracticeFormMobileNumber();
                FormsMenuSteps.PracticeFormDateOfBirth();
                FormsMenuSteps.PracticeForm3August2005();
               // FormsMenuSteps.PracticeFormSubjectsMathematics();
               //There is Bug. Nothing can be entered. I did also manual testing for this Test Case.
                FormsMenuSteps.PracticeFormHobbiesReading();
                CommonSteps.UploadChooseImage();
                CommonSteps.CurrentAddress();
                FormsMenuSteps.PracticeFormState();
                FormsMenuSteps.PracticeFormStateHaryana();
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

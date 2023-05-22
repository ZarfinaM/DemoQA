using DemoQA.CommonStepsDemoQa;
using DemoQA.FormsMenu;
using DemoQA.WidgetsMenu;

namespace DemoQa
{
    public class WidgetsMenuTestCases
    {
        public static string SliderUpTo()
        {
            string message = "";
            string sliderUpToMessage = "";


            try
            {
                CommonSteps.GoogleSearchDemoQa();
                CommonSteps.DemoQa();
                WidgetsMenuSteps.WidgetsMenu();
                WidgetsMenuSteps.Slider();
                WidgetsMenuSteps.SliderElement();



            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;

            }

            message += sliderUpToMessage;
            return message;

        }
    }
}

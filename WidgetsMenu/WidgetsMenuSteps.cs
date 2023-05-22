using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DemoQa;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;



namespace DemoQA.WidgetsMenu
{
    public class WidgetsMenuSteps
    {

    public static void WidgetsMenu()
        {
            var widgetsMenu = Driver.Instance.FindElement(By.CssSelector("#app > div > div > div.home-body > div > div:nth-child(4) > div > div.avatar.mx-auto.white"));
            widgetsMenu.Click();
        }

        public static void Slider()
        {
            var slider = Driver.Instance.FindElement(By.XPath("//span[normalize-space()='Slider']"));
            slider.Click();

        }

        public static void SliderElement()
        {
            var sliderElement = Driver.Instance.FindElement(By.CssSelector("#sliderContainer > div.col-9 > span > input"));
            sliderElement.Click();
        
        
           Actions sliderAction = new Actions(Driver.Instance);
           
           int targetPosition = 99;
               
           sliderAction.ClickAndHold(sliderElement)
                  .MoveByOffset(targetPosition,0)
                  .Release()
                  .Perform();

        }


    }
}

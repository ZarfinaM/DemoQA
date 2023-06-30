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
            var slider = Driver.Instance.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[4]/div[1]/ul[1]/li[4]/span[1]"));
            slider.Click();
        }

        public static void SliderElement()
        {
            var sliderElement = Driver.Instance.FindElement(By.CssSelector("#sliderContainer"));
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

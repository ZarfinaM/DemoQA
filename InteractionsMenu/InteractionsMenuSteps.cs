using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQa;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DemoQA.InteractionsMenu
{
    public class InteractionsMenuSteps
    {

    public static void InteractionsMenu()
        {
            var interactionsMenu = Driver.Instance.FindElement(By.CssSelector("#app > div > div > div.home-body > div > div:nth-child(5) > div > div.avatar.mx-auto.white > svg"));
            interactionsMenu.Click();
        }

        public static void Droppable()
        {
            var droppable = Driver.Instance.FindElement(By.XPath("//span[normalize-space()='Droppable']"));
            droppable.Click();
        }

        public static void DragAndDropSimple()
        {
            var dragMe = Driver.Instance.FindElement(By.CssSelector("#draggable"));
            dragMe.Click();

            var dropHere = Driver.Instance.FindElement(By.CssSelector("#droppable"));
            dropHere.Click();

            Actions builder = new Actions(Driver.Instance);
            builder.ClickAndHold(dragMe)
                   .MoveToElement(dropHere)
                   .Release()
                   .Perform();
        }
    }
}

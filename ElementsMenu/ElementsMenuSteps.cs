using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DemoQa;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ServiceStack;

namespace DemoQA.ElementsMenu
{
    public static class ElementsMenuSteps
    {
      
        public static void ElementsMenu()
        {
            var elementsDemoQa = Driver.Instance.FindElement(By.CssSelector("#app > div > div > div.home-body > div > div:nth-child(1)"));
            elementsDemoQa.Click();
        }

        public static void TextBox()
        {
            var textBox = Driver.Instance.FindElement(By.CssSelector("#item-0"));
            textBox.Click();
        }

        public static void TextBoxFullName()
        {

            var textBoxFullName = Driver.Instance.FindElement(By.CssSelector("#userName"));
            textBoxFullName.Click();
            textBoxFullName.SendKeys("Zarfina Mulalic");
        }

                public static void TextBoxPermanentAddress()
        {
            var textBoxPermanentAddress = Driver.Instance.FindElement(By.CssSelector("#permanentAddress"));
            textBoxPermanentAddress.Click();
            textBoxPermanentAddress.SendKeys("Sarajevo");
        }

       

        public static void CheckBox()
        {
            var checkBox = Driver.Instance.FindElement(By.CssSelector("#item-1 > span"));
            checkBox.Click();
        }

        public static void CheckBoxHomeDropDownMenu()
        {
            var checkBoxhomeDropDownMenu = Driver.Instance.FindElement(By.CssSelector("#tree-node > ol > li > span > button > svg"));
            checkBoxhomeDropDownMenu.Click();
        }

        public static void CheckBoxHomeDownloadsDropDownMenu()
        {
            var checkBoxHomeDownloadDropDownMenu = Driver.Instance.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(3) > span > button > svg"));
            checkBoxHomeDownloadDropDownMenu.Click();
        }

        public static void CheckBoxHomeDownloadsDropDownMenuWordFile()
        {
            var homeDownloadsMenuWordFile = Driver.Instance.FindElement(By.CssSelector("#tree-node > ol > li > ol > li.rct-node.rct-node-parent.rct-node-expanded > ol > li:nth-child(1) > span > label > span.rct-title"));
            homeDownloadsMenuWordFile.Click();
        }

        public static void RadioButton()
        {
            var radioButton = Driver.Instance.FindElement(By.CssSelector("#item-2"));
            radioButton.Click();
        }

        public static void RadioButtonYes()
        {
            var radioButtonYes = Driver.Instance.FindElement(By.CssSelector("#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(2) > div:nth-child(2) > label"));
            radioButtonYes.Click();
        }

        public static void WebTables()
        {
            var webTables = Driver.Instance.FindElement(By.CssSelector("li#item-3.btn.btn-light span.text"));
            webTables.Click();
        }

        public static void WebTablesFirstNameColumn()
        {
            var webTablesFirstNameColumn = Driver.Instance.FindElement(By.XPath("//*[@id=\"app\"]/div//div[2]/div[2]/div[2]/div[3]/div[1]/div[1]/div/div[1]/div[1]"));
            webTablesFirstNameColumn.Click();
        }

        public static void WebTablesAldenEdit()
        {
            var webTablesAldenEdit = Driver.Instance.FindElement(By.CssSelector("#edit-record-2"));
            webTablesAldenEdit.Click();
        }

        public static void WebTablesAldenChangeSalary20000()
        {
            var webTablesAldenChangeSalary20000 = Driver.Instance.FindElement(By.CssSelector("#salary"));
            webTablesAldenChangeSalary20000.Clear();
            webTablesAldenChangeSalary20000.SendKeys("20000");
        }

        public static void Buttons()
        {
            var buttons = Driver.Instance.FindElement(By.CssSelector("#item-4"));
            buttons.Click();
        }

        public static void ButtonDoubleClick()
        {
            var buttonDoubleClick = Driver.Instance.FindElement(By.CssSelector("#doubleClickBtn"));
            Actions actions = new Actions(Driver.Instance);
            actions.DoubleClick(buttonDoubleClick).Perform();
        }

        public static void ButtonRightClick()
        {
            var buttonRightClick = Driver.Instance.FindElement(By.CssSelector("#rightClickBtn"));
            Actions actions = new Actions(Driver.Instance);
            actions.ContextClick(buttonRightClick).Perform();
        }

        public static void UploadAndDownload()
        {
            var uploadandDownload = Driver.Instance.FindElement(By.CssSelector("div[class='element-list collapse show'] li[id='item-7'] span[class='text']"));
            uploadandDownload.Click();
        }

        public static void UploadChooseFileButton()
        {
            var uploadChooseFileButton = Driver.Instance.FindElement(By.CssSelector("#userForm > div:nth-child(8) > div.col-md-9.col-sm-12 > div > label"));
            uploadChooseFileButton.Click();
        }

        public static void DownloadButton()
        {
            var downloadButton = Driver.Instance.FindElement(By.CssSelector("#downloadButton"));
            downloadButton.Click();
           
        }
        public static void IsDownloadCompleted()
        {
            
         //   string downloadDirectory = "C:\\Downloads";
           // string expectedFileName = "example.txt";
            //string downloadedFilePath = System.IO.Path.Combine(downloadDirectory, expectedFileName);

            //return System.IO.File.Exists(downloadedFilePath);


           

            string downloadDirectory = "C:Users_zary_Downloads";
            string fileName = "sampleFile.jpeg";
            string downloadedFilePath = Path.Combine(downloadDirectory, fileName);

            bool fileExists = File.Exists(downloadedFilePath);

        }



    }


    }


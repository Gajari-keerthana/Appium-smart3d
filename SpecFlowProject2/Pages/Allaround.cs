using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SpecFlowProject2.Utility;
using OpenQA.Selenium.Appium;
using NUnit.Framework;
using OpenQA.Selenium.Appium.MultiTouch;


namespace SpecFlowProject2.Pages
{
    public class Allaround
    {
        private AppiumDriver<AndroidElement> driver;
        public Allaround()
        {
           this.driver = module._driver;
        }
        
        By nametext = By.Id("dk.resound.smart3d:id/demo_button");  //it clicks on the take me to demo app

        public void displaytext(string text)
        {
            Controlhelper.ButtonClick(nametext);
            
        }

        By poptext = By.XPath("//android.widget.TextView[@content-desc=\"ConsentPopupButtonOK\"]");
        By poptext1 = By.XPath("//android.widget.TextView[@content-desc=\"ConsentPopupButtonNoThanks\"]");

        public void clickonpopup()  //this method handles the popup buttons
        {
            Controlhelper.ButtonClick(poptext);
            Controlhelper.ButtonClick(poptext1);
            
        }

        By text = By.Id("dk.resound.smart3d:id/card_title");

        public string GetTitle() //this defines the HI in All Around program
        {
           return Controlhelper.GetText(text);
        }

        By split = By.Id("dk.resound.smart3d:id/SplitImageView_bottom");

        public Seekbarhandler clickonsplit() // this split the right and left volume bars
        {
            module._driver.FindElement(split).Click();
            return new Seekbarhandler();
        }

       
    }
}
    
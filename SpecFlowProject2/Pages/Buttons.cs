using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using SpecFlowProject2.Utility;
using OpenQA.Selenium;
using NUnit.Framework;
using AventStack.ExtentReports.Gherkin.Model;

namespace SpecFlowProject2.Pages
{
    public class Buttons : SoundEnhancer
    {
        private AppiumDriver<AndroidElement> driver;
        public Buttons()
        {
            this.driver = module._driver;
        }

        By speech = By.XPath("//android.widget.TextView[@content-desc=\"SmartButtonAllAroundSpeechClarity\"]");

        public void press()
        {
            Controlhelper.ButtonClick(speech);
        }

        public String ValidateText()
        {
            return Controlhelper.GetText(speech);
        }

        By noise = By.XPath("//android.widget.TextView[@content-desc=\"SmartButtonAllAroundNoiseFilter\"]");

        public void press1()
        {
            Controlhelper.ButtonClick(noise);
        }

        public void ValidateText1()
        {

            // IWebElement speechElement = driver.FindElement(speech);
            IWebElement noiseElement = module._driver.FindElement(noise);

            bool isNoiseElementEnabled = noiseElement.Enabled;
            //bool isSpeechElementDisabled = !speechElement.Enabled;

            Console.WriteLine("'Noise filter' button enabled status: " + isNoiseElementEnabled);
            // Console.WriteLine("'Speech clarity' button enabled status: " + !isSpeechElementDisabled);

            Assert.IsTrue(isNoiseElementEnabled, "'Noise filter' button is not enabled.");
            // Assert.IsTrue(isSpeechElementDisabled, "'Speech clarity' button is not disabled.");
        }

        public SoundEnhancer validateText2()
        {
            IWebElement speechElement = module._driver.FindElement(speech);
            bool isSpeechElementEnabled = speechElement.Enabled;
            Console.WriteLine("'Speech clarity' button enabled status: " + isSpeechElementEnabled);
            Assert.IsTrue(isSpeechElementEnabled, "'Speech clarity' button is not disabled.");
            return new SoundEnhancer();
        }

        By text = By.Id("dk.resound.smart3d:id/card_title");
        public String hearText()
        {
            return Controlhelper.GetText(text);
        }

        By outdoortitle = By.Id("dk.resound.smart3d:id/card_title");

        //validate program card is Outdoor
        public String outdoorText()
        {
           return Controlhelper.GetText(outdoortitle);

        }

       
        By musictitle = By.Id("dk.resound.smart3d:id/card_title");

        //validate program card is Music
        public String musicText()
        {
            return Controlhelper.GetText(musictitle);
        }

        //press Learn about the app on My ReSound
        By learn = By.XPath("//android.widget.TextView[@content-desc=\"MyResoundLearningMenuTitleApp\"]");
        public void learnaboutapp()
        {
            Controlhelper.ButtonClick(learn);
        }

        //press Volume control on Learn about the app
        By volume = By.XPath("//android.widget.TextView[@content-desc=\"HelpChapterTitleVolumeControls\"]");
        public void volumecontrol()
        {
            Controlhelper.ButtonClick(volume);
        }

        //validate Left and right volume animation is shown on Volume control
        By leftright = By.XPath("//android.widget.TextView[@content-desc=\"HelpVolumeControlsSplitTitle\"]");
        public string validatebutton()
        {
            return Controlhelper.GetText(leftright);
        }

        //validate Mute animation is shown on Volume control
        By animation = By.XPath("//android.widget.TextView[@content-desc=\"HelpVolumeControlsMuteTitle\"]");

        public string animationmute()
        {
            return Controlhelper.GetText(animation);
        }

        //close on Learn about the app and back to My Resound page
        By closevolume = By.XPath("//android.widget.ImageView[@content-desc=\"icon_close_m\"]");
        public void volumeclose()
        {
            Controlhelper.ButtonClick(closevolume);
        }

        By close = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void learningclose()
        {
            Controlhelper.ButtonClick(close);
        }

        //press Guiding tips on My ReSound
        By guiding = By.XPath("//android.widget.TextView[@content-desc=\"MyMenuNudgingTipsText\"]");
        public void guidingtips()
        {
            Controlhelper.ButtonClick(guiding);
        }

        //press OK on Please notice dialog
        By notice = By.XPath("//android.widget.TextView[@content-desc=\"NudgingArchiveDialogConfirm\"]");
        public void clicknotice()
        {
            Controlhelper.ButtonClick(notice); 
        }

        //validate title is Guiding tips on Guiding tips page
        By title = By.XPath("//android.widget.TextView[@content-desc=\"MyMenuNudgingTipsText\"]");
        public string guidingtitle()
        {
            return Controlhelper.GetText(title);
        }

        //press Noise filter on Guiding tips
        By noiseguide = By.XPath("//android.widget.TextView[@content-desc=\"NudgingFunctionalTip1Week5Header\"]");
        public void noisefilterguid()
        {
            Controlhelper.ButtonClick(noiseguide);
        }

        //press Got it on Noise filter nudging dialog
        By gotitnoise = By.XPath("//android.widget.TextView[@content-desc=\"NudgingTipConfirmButton\"]");
        public void noisegoit()
        {
            Controlhelper.ButtonClick(gotitnoise);
        }

        //press My Resound on bottom ribbon bar and back to Guiding tips on My Resound
        By pressresound = By.XPath("//android.widget.ImageView[@content-desc=\"bottom_menu_icon_person\"]");
        public void myresoundpress()
        {
            Controlhelper.ButtonClick(pressresound);
        }

        //press Music program on Guiding tips
        By musicguide = By.XPath("//android.widget.TextView[@content-desc=\"NudgingFunctionalTip1Week3Header\"]");
        public void guidingmusic()
        {
            Controlhelper.ButtonClick(musicguide);
        }

        //validate Got it button enabled on Music program nudging dialog
        By gotitmusic = By.XPath("//android.widget.TextView[@content-desc=\"NudgingTipConfirmButton\"]");
        public bool MusicGotIt()
        {
            try
            {
                return module._driver.FindElement(gotitmusic).Enabled;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        //validate Back to tips button enabled on Music program nudging dialog
        By backitmusic = By.XPath("//android.widget.TextView[@content-desc=\"NudgingTipBackToArchiveButton\"]");
        public bool backittipsmusic()
        {
            try
            {
                return module._driver.FindElement(backitmusic).Enabled;

            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

        //press Got it on Music program nudging dialog
        public void pressgotit()
        {
            Controlhelper.ButtonClick(gotitmusic);
        }

        //press menu item More on bottom ribbon bar
        By more = By.XPath("//android.widget.ImageView[@content-desc=\"bottom_menu_icon_menu\"]");
        public void moreribbon()
        {
            Controlhelper.ButtonClick(more);
        }

        //validate Auto-activate favorite locations switch is on
        By autoactive = By.XPath("//android.widget.Switch[@content-desc=\"AppAutoActivateSwitch\"]");
        public bool activefavorite()
        {
            try
            {
                return module._driver.FindElement(autoactive).GetAttribute("clickable") == "true";

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        //press Auto-activate favorite locations switch on More menu
        public void switchon()
        {
            Controlhelper.ButtonClick(autoactive);
        }

        //validate Auto-activate favorite locations switch is off
        By autoswitchoff = By.XPath("//android.widget.Switch[@content-desc=\"AppAutoActivateSwitch\"]");

        public bool activefavorite1()
        {
            try
            {
                return module._driver.FindElement(autoswitchoff).GetAttribute("clickable") == "true";

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        //press more menu item About
        By about = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralAboutText\"]");

        public void generalabout()
        {
            Controlhelper.ButtonClick(about);
        }

        //validate page title is displayed on About page
        By abouttitle = By.XPath("//android.widget.TextView[@content-desc=\"AboutHeaderTitle\"]");
        public string titleonabout()
        {
            return Controlhelper.GetText(abouttitle);
        }

        //validate html view is displayed on About page
        By content = By.ClassName("android.webkit.WebView");
        public bool viewtext()
        {
            try
            {
                return module._driver.FindElement(content).Displayed;

            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

        //press back from About page
        By aboutback = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void backbutton()
        {
            Controlhelper.ButtonClick(aboutback);
        }

        //press more menu item Legal information
        By legal = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalInformationText\"]");
        public void morelegalinfo()
        {
            Controlhelper.ButtonClick(legal);
        }

        //press Legal information item MANUFACTURER
        By manufacture = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalSubmenuManufacturerText\"]");
        public void moremanufacture()
        {
            Controlhelper.ButtonClick(manufacture);
        }

        //validate page title is displayed on Manufacturer page
        By manuftitle = By.XPath("//android.widget.TextView[@content-desc=\"ManufacturerHeaderTitle\"]");
        public string manufacturetitle()
        {
            return Controlhelper.GetText(manuftitle);
        }

        //press back from Manufacturer page
        By manufback = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void manufactureback()
        {
            Controlhelper.ButtonClick(manufback);
        }

        //press Legal information item TERMS AND CONDITIONS
        By termspage = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalSubmenuTermsOfUseText\"]");
        public void moretermspage()
        {
            Controlhelper.ButtonClick(termspage);
        }

        //validate page title is displayed on Terms and Conditions page
        By termtitle = By.XPath("//android.widget.TextView[@content-desc=\"EntryflowTitleTermsOfUse\"]");
        public string termstitlepage()
        {
            return Controlhelper.GetText(termtitle);
        }

        //press back from Terms and Conditions page
        By termback = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void backtermspage()
        {
            Controlhelper.ButtonClick(termback);
        }

        //press Legal information item PRIVACY POLICY
        By privacypage = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalSubmenuPrivacyPolicyText\"]");
        public void pageprivacy()
        {
            Controlhelper.ButtonClick(privacypage);
        }

        //validate html view is displayed on PRIVACY POLICY page
        By htmlprivacy = By.ClassName("android.webkit.WebView");
        public bool htmlprivacypage()
        {
            try
            {
                return module._driver.FindElement(htmlprivacy).Displayed;

            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

        //validate page title is displayed on PRIVACY POLICY page
        By privacytitle = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralLegalSubmenuPrivacyPolicyText\"]");
        public string pageprivacytitle()
        {
            return Controlhelper.GetText(privacytitle);
        }

        //press back from PRIVACY POLICY page
        By backprivacy = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void clickbackprivacy()
        {
            Controlhelper.ButtonClick(backprivacy);
        }

        //press back from Legal information page
        By backlegal = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void pressbacklegal()
        {
            Controlhelper.ButtonClick(backlegal);  
        }

        //press more menu item Support
        By support = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralSupportText\"]");
        public void moresupport()
        {
            Controlhelper.ButtonClick(support);
        }

        //validate html view is displayed on Support page
        By supporthtml = By.XPath("(//android.webkit.WebView[@index='0'])[1]");
        public bool supporthtmlpage()
        {
            try
            {
                return module._driver.FindElement(supporthtml).Displayed;

            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

        //validate page title is displayed on Support page
        By supporttitle = By.XPath("//android.widget.TextView[@content-desc=\"MoreGeneralSupportText\"]");
        public string titlepagesupport()
        {
            return Controlhelper.GetText(supporttitle);
        }

        //press back from Support page
        By backsupport = By.XPath("//android.widget.ImageView[@content-desc=\"icon_arrow_back_m\"]");
        public void pressbacksupportpage()
        {
            Controlhelper.ButtonClick(backsupport);
        }

        //press menu item Home on bottom ribbon bar
        By presshome = By.Id("dk.resound.smart3d:id/home_tab");
        public void homebackpage()
        {
            Controlhelper.ButtonClick(presshome);
        }
    }
}

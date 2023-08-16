using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using SpecFlowProject2.Utility;
using OpenQA.Selenium;


namespace SpecFlowProject2.Pages
{
    public class SoundEnhancer
    {
        private AppiumDriver<AndroidElement> driver;
        public SoundEnhancer()
        {
            this.driver = module._driver;
        }

        By soundEnhancer = By.XPath("//android.widget.TextView[@content-desc=\"HomeButtonLabelFineTune\"]");

        public void sound()
        {
            Controlhelper.ButtonClick(soundEnhancer);
        }

        By Tinnitus = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneSwitchButtonTitleTinnitusManager\"]");

        public void tinnitusmanager()
        {
            Controlhelper.ButtonClick(Tinnitus);
        }

        By calming = By.XPath("//android.widget.Button[@content-desc=\"TsgNatureSoundsCalmingWaves\"]");
        By Breaking = By.XPath("//android.widget.Button[@content-desc=\"TsgNatureSoundsBreakingWaves\"]");
        By Sound = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneSwitchButtonTitleFinetune\"]");
        By exit = By.XPath("//android.widget.ImageView[@content-desc=\"icon_close_m\"]");

        public void calmingwaves()
        {
            Controlhelper.ButtonClick(calming);
        }

        //press Nature sound button Breaking Waves on All Around Tinnitus manager
        public void breakingwaves()
        {
            Controlhelper.ButtonClick(Breaking);
        }

        public void Soundenhancer()
        {
            Controlhelper.ButtonClick(Sound);
        }

        //press the exit button on All Around Sound enhancer
        public void exitbutton()
        {
            Controlhelper.ButtonClick(exit);
        }

        //press Sound Enhancer button on Hear in noise program
        By hearsound = By.XPath("//android.widget.TextView[@content-desc=\"HomeButtonLabelFineTune\"]");

        public void hearsoundnoise()
        {
            Controlhelper.ButtonClick(hearsound);
        }

        //press Tinnitus Manager on Hear in noise Sound Enhancer
        By hearTinnitus = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneSwitchButtonTitleTinnitusManager\"]");

        public void heartinnitussound()
        {
            Controlhelper.ButtonClick(hearTinnitus);
        }

        //press white noise button Slight variation on Hear in noise Tinnitus Manager
        By slightvariation = By.XPath("//android.widget.Button[@content-desc=\"TsgWhiteNoiseVariationsSlight\"]");

        public void slightvar()
        {
            Controlhelper.ButtonClick(slightvariation);
        }

        By reset = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneButtonReset\"]");

        public void resetbutton() //press Reset button on All-Around Tinnitus Manager
        {
            Controlhelper.ButtonClick(reset);
        }

        By sound1 = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneSwitchButtonTitleFinetune\"]");
        By exit1 = By.XPath("//android.widget.ImageView[@content-desc=\"icon_close_m\"]");

        public void soundenh() //press the exit button on Hear in noise Sound Enhancer
        {
            Controlhelper.ButtonClick(sound1);
            Controlhelper.ButtonClick(exit1);
        }

        //press Sound Enhancer button on Outdoor program
        By outdoorsound = By.XPath("//android.widget.TextView[@content-desc=\"HomeButtonLabelFineTune\"]");
        public void outdoorsoundnoise()
        {
            Controlhelper.ButtonClick(outdoorsound);
        }

        // press the exit button on Outdoor Sound Enhancer
        By soundexit = By.XPath("//android.widget.ImageView[@content-desc=\"icon_close_m\"]");

        public void soundExit()
        {
            Controlhelper.ButtonClick(soundexit);
        }


    }
}

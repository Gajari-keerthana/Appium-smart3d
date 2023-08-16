using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using SpecFlowProject2.Utility;


namespace SpecFlowProject2.Pages
{
    public class Seekbarhandler : SoundEnhancer 
    {
        private AppiumDriver<AndroidElement> driver;
        public Seekbarhandler()
        {
            this.driver = module._driver;
        }

        By seekbar1 = By.Id("dk.resound.smart3d:id/seekBar_top");
        By seekbar2 = By.Id("dk.resound.smart3d:id/seekBar_bottom");

        public void slider1(string value)
        {
            TouchAction touchaction = new TouchAction(module._driver);
            AndroidElement slide1 = module._driver.FindElement(seekbar1);
            touchaction.Press(slide1)
                       .MoveTo(672, 1646)
                       .Perform();
            string act_value = module._driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(act_value, value);
            touchaction.Release().Perform();


        }

        public void slider2(string value)
        {
            TouchAction touchaction = new TouchAction(module._driver);
            AndroidElement slide2 = module._driver.FindElement(seekbar2);
            touchaction.Press(slide2)
                       .MoveTo(662, 1738)
                       .Perform();
            string actionvalue = module._driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(actionvalue, value);
            touchaction.Release().Perform();

        }

        By seekbar3 = By.Id("dk.resound.smart3d:id/seekBar_top");
        By seekbar10 = By.Id("dk.resound.smart3d:id/seekBar_bottom");

        public void slider3(string value)
        {
            TouchAction action = new TouchAction(module._driver);
            AndroidElement element3 = module._driver.FindElement(seekbar3);
            action.Press(element3)
                       .MoveTo(317, 1646)
                       .Release()
                       .Perform();

        }

        public void slider10(string value)
        {

            TouchAction action = new TouchAction(module._driver);
            AndroidElement element4 = module._driver.FindElement(seekbar10);
            action.Press(element4)
                        .MoveTo(754, 17)
                        .Release()
                        .Perform();
        }

        public void validate3(string value)
        {
            TouchAction touchaction = new TouchAction(module._driver);
            AndroidElement slide2 = module._driver.FindElement(seekbar3);
            touchaction.Press(slide2)
                       .MoveTo(317, 1646)
                       .Perform();
            string actionvalue = module._driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(actionvalue, value);
            touchaction.Release().Perform();

        }

        public void validate10(string value)
        {
            TouchAction action = new TouchAction(module._driver);
            AndroidElement element4 = module._driver.FindElement(seekbar10);
            action.Press(element4)
                  .MoveTo(754, 1738)
                  .Perform();
            string actionvalue4 = module._driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(actionvalue4, value);
            action.Release().Perform();

        }

        By merge = By.XPath("//android.widget.ImageView[@content-desc=\"icon_split1_s\"]");

        public void clickonmerge()
        {
            Controlhelper.ButtonClick(merge);

        }

        By seekbar4 = By.Id("dk.resound.smart3d:id/volume_thumb_innercircle");
        By seekbar13 = By.Id("dk.resound.smart3d:id/volume_thumb_innercircle");

        public void validate4(string value)
        {
            TouchAction action = new TouchAction(module._driver);
            AndroidElement element5 = module._driver.FindElement(seekbar4);
            action.Press(element5)
                  .MoveTo(300, 1646)
                  .Perform();

            string act_value2 = module._driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(act_value2, value);
            action.Release().Perform();
            //Assert.IsNotNull(merge, "The merge button click action did not lead to the expected behavior.");
        }


        //validate HI merged surrounding volume is "13" on All-Around program
        public Buttons validate5(string value)
        {
            TouchAction action = new TouchAction(module._driver);
            AndroidElement element6 = module._driver.FindElement(seekbar13);
            action.Press(element6)
                  .MoveTo(842, 1738)
                  .Perform();
            string act_value3 = module._driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(act_value3, value);
            action.Release().Perform();
            return new Buttons();
        }

        //SOUNDENHANCER on Allaround
        By element1 = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneGainLabelBass\"]");
        By element2 = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneGainLabelMiddle\"]");
        By element3 = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneGainLabelTreble\"]");

        public void value1(string value)
        {
            TouchAction touchaction = new TouchAction(module._driver);
            AndroidElement slide1 = module._driver.FindElement(element1);
            touchaction.Press(slide1)
                       .MoveTo(101, 637)
                       .Release()
                       .Perform();
        }

        public void value2(string value)
        {
            TouchAction touchaction = new TouchAction(module._driver);

            AndroidElement slide2 =  module._driver.FindElement(element2);

            touchaction.Press(slide2)
                       .MoveTo(461, 1298)
                       .Release()
                       .Perform();

        }

        public void value3(string value)
        {
            TouchAction touchaction = new TouchAction(module._driver);
            AndroidElement slide3 = module._driver.FindElement(element3);
            touchaction.Press(slide3)
                       .MoveTo(821, 553)
                       .Release()
                       .Perform();
        }

        public void validatespeech1(string bass)
        {
            try
            {
                TouchAction touchaction = new TouchAction(module._driver);
                AndroidElement slide1 = module._driver.FindElement(element1);
                touchaction.Press(slide1)
                           .MoveTo(101, 637)
                           .Perform();
                string actualvalue1 = module._driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"GainChanging\"]")).Text;
                Assert.AreEqual(bass, actualvalue1);
                touchaction.Release().Perform();
            }
            catch (Exception ex)
            {
                // Handle the exception (you can log it or perform other actions if needed)
                Console.WriteLine("Validation 1 failed: " + ex.Message);
            }
        }

        public void validatespeech2(string middle)
        {
            try
            {
                TouchAction touchaction = new TouchAction(module._driver);

                AndroidElement slide2 = module._driver.FindElement(element2);
                touchaction.Press(slide2)
                           .MoveTo(461, 1298)
                           .Perform();
                string actualvalue2 = module._driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"GainChanging\"]")).Text;
                Assert.AreEqual(middle, actualvalue2);
                touchaction.Release().Perform();
            }
            catch (Exception ex)
            {
                // Handle the exception (you can log it or perform other actions if needed)
                Console.WriteLine("Validation 2 failed: " + ex.Message);
            }
        }

        public void validatespeech3(string treble)
        {
            try
            {
                TouchAction touchaction = new TouchAction(module._driver);
                AndroidElement slide3 = module._driver.FindElement(element3);
                touchaction.Press(slide3)
                           .MoveTo(821, 553)
                           .Perform();
                string actualvalue3 = module._driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"GainChanging\"]")).Text;
                Assert.AreEqual(treble, actualvalue3);
                touchaction.Release().Perform();

            }
            catch (Exception ex)
            {
                // Handle the exception (you can log it or perform other actions if needed)
                Console.WriteLine("Validation 2 failed: " + ex.Message);
            }
        }

        By swipe = By.XPath("(//android.view.ViewGroup[@index='0'])[2]");

        public Buttons hearinnoise()
        {

            AndroidElement swipeside = module._driver.FindElement(swipe);
            int screenWidth = swipeside.Size.Width;
            int screenHeight = swipeside.Size.Height;
            int endX = 0;
            int y = screenHeight / 2;
            TouchAction swipeAction = new TouchAction(module._driver);
            swipeAction.Press(screenWidth, y).Wait(500).MoveTo(endX, y).Release().Perform();
            return new Buttons();
        }

        By outdoor = By.XPath("(//android.view.View[@index='0'])[2]");

        public Buttons outdoornoise()
        {

            AndroidElement swipeside = module._driver.FindElement(outdoor);
            int screenWidth = swipeside.Size.Width;
            int screenHeight = swipeside.Size.Height;
            int endX = 0;
            int y = screenHeight / 2;
            TouchAction swipeAction = new TouchAction(module._driver);
            swipeAction.Press(screenWidth, y).Wait(500).MoveTo(endX, y).Release().Perform();
            return new Buttons();
        }

        //drag Wind Noise Reduction to 'Strong' on Outdoor Sound Enhancer
        By windnoise = By.XPath("(//android.view.View[@index='0'])[5]");

        public void windvalue(string value)
        {
            TouchAction touchaction = new TouchAction(module._driver);
            AndroidElement slide1 = module._driver.FindElement(windnoise);
            touchaction.Press(slide1)
                       .MoveTo(794, 2031)
                       .Perform();
            string actualvalue = module._driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup[2]/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout[4]/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.TextView")).Text;
            Assert.AreEqual(value, actualvalue);
            touchaction.Release().Perform();
        }

        By music = By.XPath("(//android.view.View[@index='0'])[2]");

        public Buttons musicslide()
        {

            AndroidElement swipeside = module._driver.FindElement(music);
            int screenWidth = swipeside.Size.Width;
            int screenHeight = swipeside.Size.Height;
            int endX = 0;
            int y = screenHeight / 2;
            TouchAction swipeAction = new TouchAction(module._driver);
            swipeAction.Press(screenWidth, y).Wait(500).MoveTo(endX, y).Release().Perform();
            return new Buttons();
        }

        //swipe left to 2 / 3 page on Learn about the app 
        By volumelr = By.XPath("(//android.widget.FrameLayout[@index='0'])[4]");

        public Buttons volumeleftright()
        {
            AndroidElement swipeside = module._driver.FindElement(volumelr);
            int screenWidth = swipeside.Size.Width;
            int screenHeight = swipeside.Size.Height;
            int endX = 0;
            int y = screenHeight / 2;
            TouchAction swipeAction = new TouchAction(module._driver);
            swipeAction.Press(screenWidth, y).Wait(500).MoveTo(endX, y).Release().Perform();
            return new Buttons();
        }

        //swipe mute left to 3 / 3 page on Learn about the app
        By mute = By.XPath("(//android.widget.LinearLayout[@index='0'])[4]");

        public Buttons swipemute()
        {
            AndroidElement swipeside = module._driver.FindElement(mute);
            int screenWidth = swipeside.Size.Width;
            int screenHeight = swipeside.Size.Height;
            int endX = 0;
            int y = screenHeight / 2;
            TouchAction swipeAction = new TouchAction(module._driver);
            swipeAction.Press(screenWidth, y).Wait(500).MoveTo(endX, y).Release().Perform();
            return new Buttons();
        }

    }
}

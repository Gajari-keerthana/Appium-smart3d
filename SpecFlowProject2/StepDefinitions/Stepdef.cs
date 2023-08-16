using OpenQA.Selenium.Appium.Android;
using SpecFlowProject2.Pages;
using SpecFlowProject2.Utility;
using OpenQA.Selenium.Appium;
using NUnit.Framework;
using OpenQA.Selenium;
using AventStack.ExtentReports.Gherkin.Model;
using Dynamitey;
using System.ComponentModel.DataAnnotations;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public sealed class Stepdef
    {

        private  AppiumDriver<AndroidElement> driver;
        private Allaround allaround;
        private Seekbarhandler seekbarhandler;
        private Buttons buttons;
        private SoundEnhancer soundEnhancer;
        private Ribbonbar ribbonbar;

        public Stepdef()
        {
            this.driver = module._driver;
            allaround = new Allaround();
            seekbarhandler = new Seekbarhandler();
            buttons = new Buttons();
            soundEnhancer = new SoundEnhancer();
            
        }

        [Given(@"open the app\.")]
        public void GivenOpenTheApp()
        {
            
        }

        [When(@"click on the take me to demo app")]
        public void WhenClickOnTheTakeMeToDemoApp()
        {
            allaround.displaytext("No, take me to demo mode");
        }

        [When(@"opens the app displays the popup button and click on the button\.")]
        public void WhenOpensTheAppDisplaysThePopupButtonAndClickOnTheButton_()
        {
            
            allaround.clickonpopup();
        }

        [When(@"HI program in All-Around")]
        public void WhenHIProgramInAll_Around()
        {
            //this.driver = module._driver;
            string expectedTitle = "All-Around";
            string actualTitle = allaround.GetTitle();

            Assert.AreEqual(expectedTitle, actualTitle, "The page title does not match the expected title.");
        }

        [When(@"display the Right HI and Left HI volumes")]
        public void WhenDisplayTheRightHIAndLeftHIVolumes()
        {
            //this.driver = module._driver;
            allaround.clickonsplit();
        }

        [When(@"validate the Right HI and Left HI values is ""([^""]*)""")]
        public void WhenValidateTheRightHIAndLeftHIValuesIs(string p0)
        {
            //this.driver = module._driver;
            seekbarhandler.slider1(p0);
            seekbarhandler.slider2(p0);
        }

        [When(@"set surrounding volume is ""([^""]*)"" on Right HI and  ""([^""]*)"" on Left HI")]
        public void WhenSetSurroundingVolumeIsOnRightHIAndOnLeftHI(string p0, string p1)
        {
            //this.driver = module._driver;
            seekbarhandler.slider3(p0);
            seekbarhandler.slider10(p1);
        }

        [When(@"validate the surrounding volume is ""([^""]*)"" on Right HI and ""([^""]*)"" on Left HI")]
        public void WhenValidateTheSurroundingVolumeIsOnRightHIAndOnLeftHI(string p0, string p1)
        {
            //this.driver = module._driver;
            seekbarhandler.validate3(p0);
            seekbarhandler.validate10(p1);
        }

        [When(@"merge surroundings volume on All-Around program")]
        public void WhenMergeSurroundingsVolumeOnAll_AroundProgram()
        {
            seekbarhandler.clickonmerge();
        }

        [When(@"validate merged surroundings volume is ""([^""]*)"" on All-Around program")]
        public void WhenValidateMergedSurroundingsVolumeIsOnAll_AroundProgram(string p0)
        {
            seekbarhandler.validate4(p0);
        }

        [When(@"validate HI merged surrounding volume is ""([^""]*)"" on All-Around program")]
        public void WhenValidateHIMergedSurroundingVolumeIsOnAll_AroundProgram(string p0)
        {
            seekbarhandler.validate5(p0);
        }

        [When(@"press speech clarity button on All Around program and validate speech clarity button is enabled")]
        public void WhenPressSpeechClarityButtonOnAllAroundProgramAndValidateSpeechClarityButtonIsEnabled()
        {
            buttons.press();
            string expectedTitle = "Speech clarity";
            string actualTitle = buttons.ValidateText();
            actualTitle = actualTitle.Replace("\r", "").Replace("\n", " ");


            Assert.AreEqual(expectedTitle, actualTitle, "validate 'Speech clarity' quick button is enabled on 'All-Around' program");
        }

        [When(@"press on Noise filter button on All Around program")]
        public void WhenPressOnNoiseFilterButtonOnAllAroundProgram()
        {
            buttons.press1();
        }

        [When(@"validate Noise filter button is enabled and speech clarity button is disabled\.")]
        public void WhenValidateNoiseFilterButtonIsEnabledAndSpeechClarityButtonIsDisabled_()
        {
            buttons.ValidateText1();
        }

        [When(@"press on speech clarity button on All Around program")]
        public void WhenPressOnSpeechClarityButtonOnAllAroundProgram()
        {
            buttons.press();
        }

        [When(@"validate speech clarity button is enabled and Noise filter button is disabled\.")]
        public void WhenValidateSpeechClarityButtonIsEnabledAndNoiseFilterButtonIsDisabled_()
        {
            buttons.validateText2();
        }

        [When(@"press on Sound Enhancer button on All Around program")]
        public void WhenPressOnSoundEnhancerButtonOnAllAroundProgram()
        {
            soundEnhancer.sound();
        }

        [When(@"set Bass gain to '([^']*)' Middle gain to '([^']*)' Treble gain to '([^']*)'")]
        public void WhenSetBassGainToMiddleGainToTrebleGainTo(string p0, string p1, string p2)
        {
            seekbarhandler.value1(p0);
            seekbarhandler.value2(p1);
            seekbarhandler.value3(p2);
        }

        [When(@"Then validate Bass gain to '([^']*)' Middle gain to '([^']*)' Treble gain to '([^']*)'")]
        public void WhenThenValidateBassGainToMiddleGainToTrebleGainTo(string p0, string p1, string p2)
        {
            seekbarhandler.validatespeech1(p0);
            seekbarhandler.validatespeech2(p1);
            seekbarhandler.validatespeech3(p2);
        }

        [When(@"I press on Tinnitus Manager on All Around  Sound Enhancer")]
        public void WhenIPressOnTinnitusManagerOnAllAroundSoundEnhancer()
        {
            soundEnhancer.tinnitusmanager();
        }

        [When(@"I press Nature sound button Calming Waves on All Around Tinnitus manager")]
        public void WhenIPressNatureSoundButtonCalmingWavesOnAllAroundTinnitusManager()
        {
            soundEnhancer.calmingwaves();
        }


        [When(@"I press Nature sound button Breaking Waves on All Around Tinnitus manager")]
        public void WhenIPressNatureSoundButtonBreakingWavesOnAllAroundTinnitusManager()
        {
            soundEnhancer.breakingwaves();
        }

        [When(@"I press the exit button on All Around Sound enhancer")]
        public void WhenIPressTheExitButtonOnAllAroundSoundEnhancer()
        {
            soundEnhancer.Soundenhancer();
            soundEnhancer.exitbutton();
        }

        [When(@"I swipe left to Hear in Noise program from current program")]
        public void WhenISwipeLeftToHearInNoiseProgramFromCurrentProgram()
        {
            seekbarhandler.hearinnoise();
        }

        [When(@"validate program card is Hear in Noise")]
        public void WhenValidateProgramCardIsHearInNoise()
        {
            string expectedTitle = "Hear in noise";
            string actualTitle = buttons.hearText();
            Assert.AreEqual(expectedTitle, actualTitle, "Then validate program card is Hear in Noise");
        }

        [When(@"I press Sound Enhancer button on Hear in noise program")]
        public void WhenIPressSoundEnhancerButtonOnHearInNoiseProgram()
        {
            soundEnhancer.hearsoundnoise();
        }

        [When(@"I press Tinnitus Manager on Hear in noise Sound Enhancer")]
        public void WhenIPressTinnitusManagerOnHearInNoiseSoundEnhancer()
        {
            soundEnhancer.heartinnitussound();
        }

        [When(@"I press white noise button Slight variation on Hear in noise Tinnitus Manager")]
        public void WhenIPressWhiteNoiseButtonSlightVariationOnHearInNoiseTinnitusManager()
        {
            soundEnhancer.slightvar();
        }

        [When(@"I press Reset button on All-Around Tinnitus Manager")]
        public void WhenIPressResetButtonOnAll_AroundTinnitusManager()
        {
            soundEnhancer.resetbutton();
        }

        [When(@"I press the exit button on Hear in noise Sound Enhancer")]
        public void WhenIPressTheExitButtonOnHearInNoiseSoundEnhancer()
        {
            soundEnhancer.soundenh();
        }

        [When(@"I swipe left to Outdoor program from current program")]
        public void WhenISwipeLeftToOutdoorProgramFromCurrentProgram()
        {
            seekbarhandler.outdoornoise();
        }

        [Then(@"validate program card is Outdoor")]
        public void ThenValidateProgramCardIsOutdoor()
        {
            string expectedTitle = "Outdoor";
            string actualTitle = buttons.outdoorText();
            Assert.AreEqual(expectedTitle, actualTitle, "validate program card is Outdoor");
        }

        [When(@"I press Sound Enhancer button on Outdoor program")]
        public void WhenIPressSoundEnhancerButtonOnOutdoorProgram()
        {
            soundEnhancer.outdoorsoundnoise();
        }

        [When(@"I drag Wind Noise Reduction to Strong on Outdoor Sound Enhancer and validate HI PNR value is '([^']*)'")]
        public void WhenIDragWindNoiseReductionToStrongOnOutdoorSoundEnhancerAndValidateHIPNRValueIs(string strong)
        {
            seekbarhandler.windvalue(strong);
        }
        
        [When(@"I press the exit button on Outdoor Sound Enhancer")]
        public void WhenIPressTheExitButtonOnOutdoorSoundEnhancer()
        {
            soundEnhancer.soundExit();
        }

        [When(@"I swipe left to Music program from current program")]
        public void WhenISwipeLeftToMusicProgramFromCurrentProgram()
        {
            seekbarhandler.musicslide();
        }

        [When(@"validate program card is Music")]
        public void WhenValidateProgramCardIsMusic()
        {
            string expectedTitle = "Music";
            string actualTitle = buttons.musicText();
            Assert.AreEqual(expectedTitle, actualTitle, "validate program card is Music");
        }

        [When(@"I press Music program on the top ribbon bar")]
        public void WhenIPressMusicProgramOnTheTopRibbonBar()
        {
            ribbonbar.topribbon();
        }

        [When(@"validate program card is Musicribbon")]
        public void WhenValidateProgramCardIsMusicribbon()
        {
            string expectedTitle = "Music";
            string actualTitle = buttons.musicText();
            Assert.AreEqual(expectedTitle, actualTitle, "validate program card is Music");
        }

        [When(@"I press Outdoor program on the top ribbon bar")]
        public void WhenIPressOutdoorProgramOnTheTopRibbonBar()
        {
            ribbonbar.topoutribbon1();
        }

        [When(@"validate program card is Outdoorribbon")]
        public void WhenValidateProgramCardIsOutdoorribbon()
        {
            string expectedTitle = "Outdoor";
            string actualTitle = buttons.outdoorText();
            Assert.AreEqual(expectedTitle, actualTitle, "validate program card is Outdoor");
        }

        [When(@"I press Hear in noise program on the top ribbon bar")]
        public void WhenIPressHearInNoiseProgramOnTheTopRibbonBar()
        {
            ribbonbar.tophearribbon2();
        }

        [When(@"validate program card is Hear in Noiseribbon")]
        public void WhenValidateProgramCardIsHearInNoiseribbon()
        {
            string expectedTitle = "Hear in noise";
            string actualTitle = buttons.hearText();
            Assert.AreEqual(expectedTitle, actualTitle, "Then validate program card is Hear in Noise");
        }

        [When(@"I press All-Around program on the top ribbon bar")]
        public void WhenIPressAll_AroundProgramOnTheTopRibbonBar()
        {
            ribbonbar.topAllaroundribbon3();
        }

        [When(@"validate program card is All-Around")]
        public void WhenValidateProgramCardIsAll_Around()
        {
            string expectedTitle = "All-Around";
            string actualTitle = allaround.GetTitle();

            Assert.AreEqual(expectedTitle, actualTitle, "The page title does not match the expected title.");
        }

        [When(@"I press Program overview button on topribbonbar")]
        public void WhenIPressProgramOverviewButtonOnTopribbonbar()
        {
            ribbonbar.programdrag();
        }

        [When(@"I press Hear in noise program on Program overview")]
        public void WhenIPressHearInNoiseProgramOnProgramOverview()
        {
            ribbonbar.programhear();
        }

        [When(@"I press Outdoor program on Program overview")]
        public void WhenIPressOutdoorProgramOnProgramOverview()
        {
            ribbonbar.programoutdoor();
        }

        [When(@"I press Music program on Program overview")]
        public void WhenIPressMusicProgramOnProgramOverview()
        {
            ribbonbar.programmusic();
        }

        [When(@"I press All-Around program on Program overview")]
        public void WhenIPressAll_AroundProgramOnProgramOverview()
        {
            ribbonbar.programAllaround();
        }

        [When(@"I press the Close button on Program overview")]
        public void WhenIPressTheCloseButtonOnProgramOverview()
        {
            ribbonbar.programclose();
        }

        [When(@"I press menu item My ReSound on bottom ribbon bar")]
        public void WhenIPressMenuItemMyReSoundOnBottomRibbonBar()
        {
            ribbonbar.resound();
        }

        [When(@"I press Learn about the app on My ReSound")]
        public void WhenIPressLearnAboutTheAppOnMyReSound()
        {
            buttons.learnaboutapp();
        }

        [When(@"I press Volume control on Learn about the app")]
        public void WhenIPressVolumeControlOnLearnAboutTheApp()
        {
            buttons.volumecontrol();
        }

        [When(@"I swipe left to (.*) / (.*) page on Learn about the app")]
        public void WhenISwipeLeftToPageOnLearnAboutTheApp(int p0, int p1)
        {
            seekbarhandler.volumeleftright();
        }

        [Then(@"validate Left and right volume animation is shown on Volume control")]
        public void ThenValidateLeftAndRightVolumeAnimationIsShownOnVolumeControl()
        {
            string expectedTitle = "Left and right volume";
            string actualTitle = buttons.validatebutton();
            Assert.AreEqual(expectedTitle, actualTitle, "validate Left and right volume animation is shown on Volume control");
        }

        [When(@"I swipe mute left to (.*) / (.*) page on Learn about the app")]
        public void WhenISwipeMuteLeftToPageOnLearnAboutTheApp(int p0, int p1)
        {
            seekbarhandler.swipemute();
        }

        [Then(@"validate Mute animation is shown on Volume control")]
        public void ThenValidateMuteAnimationIsShownOnVolumeControl()
        {
            string expectedTitle = "Mute";
            string actualTitle = buttons.animationmute();
            Assert.AreEqual(expectedTitle, actualTitle, "validate Mute animation is not shown on Volume control");
        }

        [When(@"I close on Learn about the app and back to My Resound page")]
        public void WhenICloseOnLearnAboutTheAppAndBackToMyResoundPage()
        {
            buttons.volumeclose();
            buttons.learningclose();
        }

        [When(@"I press Guiding tips on My ReSound")]
        public void WhenIPressGuidingTipsOnMyReSound()
        {
            buttons.guidingtips();
        }

        [When(@"I press OK on Please notice dialog")]
        public void WhenIPressOKOnPleaseNoticeDialog()
        {
            buttons.clicknotice();
        }

        [Then(@"validate title is Guiding tips on Guiding tips page")]
        public void ThenValidateTitleIsGuidingTipsOnGuidingTipsPage()
        {
            string expectedTitle = "Guiding tips";
            string actualTitle = buttons.guidingtitle();
            Assert.AreEqual(expectedTitle, actualTitle, "validate title is not Guiding tips on Guiding tips page");
        }

        [When(@"I press Noise filter on Guiding tips")]
        public void WhenIPressNoiseFilterOnGuidingTips()
        {
            buttons.noisefilterguid();
        }

        [When(@"I press Got it on Noise filter nudging dialog")]
        public void WhenIPressGotItOnNoiseFilterNudgingDialog()
        {
            buttons.noisegoit();
        }

        [When(@"I press My Resound on bottom ribbon bar and back to Guiding tips on My Resound")]
        public void WhenIPressMyResoundOnBottomRibbonBarAndBackToGuidingTipsOnMyResound()
        {
            buttons.myresoundpress();
        }

        [When(@"I press Music program on Guiding tips")]
        public void WhenIPressMusicProgramOnGuidingTips()
        {
            buttons.guidingmusic();
        }

        [Then(@"validate Got it button enabled on Music program nudging dialog")]
        public void ThenValidateGotItButtonEnabledOnMusicProgramNudgingDialog()
        {
            bool isButtonEnabled = buttons.MusicGotIt();
            Assert.IsTrue(isButtonEnabled, "The got ot button should be enabled, but it is not");
        }

        [Then(@"validate Back to tips button enabled on Music program nudging dialog")]
        public void ThenValidateBackToTipsButtonEnabledOnMusicProgramNudgingDialog()
        {
            bool isButtonEnabled = buttons.backittipsmusic();
            Assert.IsTrue(isButtonEnabled, "The got ot button should be enabled, but it is not");
        }

        [When(@"I press Got it on Music program nudging dialog")]
        public void WhenIPressGotItOnMusicProgramNudgingDialog()
        {
            buttons.pressgotit();
        }

        [When(@"I press menu item More on bottom ribbon bar")]
        public void WhenIPressMenuItemMoreOnBottomRibbonBar()
        {
            buttons.moreribbon();
        }

        [Then(@"validate Auto-activate favorite locations switch is on")]
        public void ThenValidateAuto_ActivateFavoriteLocationsSwitchIsOn()
        {
            bool isClicked = buttons.activefavorite();
            Assert.IsTrue(isClicked, "The autoactive switch is not selected");
        }

        [When(@"I press Auto-activate favorite locations switch on More menu")]
        public void WhenIPressAuto_ActivateFavoriteLocationsSwitchOnMoreMenu()
        {
            buttons.switchon();
        }

        [Then(@"validate Auto-activate favorite locations switch is off")]
        public void ThenValidateAuto_ActivateFavoriteLocationsSwitchIsOff()
        {
            bool isClicked = buttons.activefavorite1();
            Assert.IsTrue(isClicked, "The autoactive switch is not selected");
        }

        [When(@"I press Auto-activate favorite locations switch on Moremenu")]
        public void WhenIPressAuto_ActivateFavoriteLocationsSwitchOnMoremenu()
        {
            buttons.switchon();
        }

        [Then(@"validate Autoactivate favorite locations switch is on")]
        public void ThenValidateAutoactivateFavoriteLocationsSwitchIsOn()
        {
            bool isClicked = buttons.activefavorite();
            Assert.IsTrue(isClicked, "The autoactive switch is not selected");
        }

        [When(@"I press more menu item About")]
        public void WhenIPressMoreMenuItemAbout()
        {
            buttons.generalabout();
        }

        [Then(@"validate page title is displayed on About page")]
        public void ThenValidatePageTitleIsDisplayedOnAboutPage()
        {
            string expectedTitle = "About";
            string actualTitle = buttons.titleonabout();
            Assert.AreEqual(expectedTitle, actualTitle, "validate title is not about page");
        }

        [Then(@"validate html view is displayed on About page")]
        public void ThenValidateHtmlViewIsDisplayedOnAboutPage()
        {
            bool isButtonDisplayed = buttons.viewtext();
            Assert.IsTrue(isButtonDisplayed, "The validate html view is not displayed on About page");
        }

        [When(@"I press back from About page")]
        public void WhenIPressBackFromAboutPage()
        {
            buttons.backbutton();
        }

        [When(@"I press more menu item Legal information")]
        public void WhenIPressMoreMenuItemLegalInformation()
        {
            buttons.morelegalinfo();
        }

        [When(@"I press Legal information item MANUFACTURER")]
        public void WhenIPressLegalInformationItemMANUFACTURER()
        {
            buttons.moremanufacture();
        }

        [Then(@"validate page title is displayed on Manufacturer page")]
        public void ThenValidatePageTitleIsDisplayedOnManufacturerPage()
        {
            string expectedTitle = "Manufacturer";
            string actualTitle = buttons.manufacturetitle();
            Assert.AreEqual(expectedTitle, actualTitle, "validate title is not manufacture page");
        }

        [When(@"I press back from Manufacturer page")]
        public void WhenIPressBackFromManufacturerPage()
        {
            buttons.manufactureback();
        }

        [When(@"I press Legal information item TERMS AND CONDITIONS")]
        public void WhenIPressLegalInformationItemTERMSANDCONDITIONS()
        {
            buttons.moretermspage();
        }

        [Then(@"validate page title is displayed on Terms and Conditions page")]
        public void ThenValidatePageTitleIsDisplayedOnTermsAndConditionsPage()
        {
            string expectedTitle = "Terms and Conditions";
            string actualTitle = buttons.termstitlepage();
            Assert.AreEqual(expectedTitle, actualTitle, "validate title is not terms and condition page");
        }

        [When(@"I press back from Terms and Conditions page")]
        public void WhenIPressBackFromTermsAndConditionsPage()
        {
            buttons.backtermspage();
        }

        [When(@"I press Legal information item PRIVACY POLICY")]
        public void WhenIPressLegalInformationItemPRIVACYPOLICY()
        {
            buttons.pageprivacy();
        }

        [Then(@"validate html view is displayed on PRIVACY POLICY page")]
        public void ThenValidateHtmlViewIsDisplayedOnPRIVACYPOLICYPage()
        {
            bool isButtonDisplayed = buttons.htmlprivacypage();
            Assert.IsTrue(isButtonDisplayed, "The validate html view is not displayed on privacy page");
        }

        [Then(@"validate page title is displayed on PRIVACY POLICY page")]
        public void ThenValidatePageTitleIsDisplayedOnPRIVACYPOLICYPage()
        {
            string expectedTitle = "PRIVACY POLICY";
            string actualTitle = buttons.pageprivacytitle();
            Assert.AreEqual(expectedTitle, actualTitle, "validate title is not privacy page");
        }

        [When(@"I press back from PRIVACY POLICY page")]
        public void WhenIPressBackFromPRIVACYPOLICYPage()
        {
            buttons.clickbackprivacy();
        }

        [When(@"I press back from Legal information page")]
        public void WhenIPressBackFromLegalInformationPage()
        {
            buttons.pressbacklegal();
        }

        [When(@"I press more menu item Support")]
        public void WhenIPressMoreMenuItemSupport()
        {
            buttons.moresupport();
        }

        [Then(@"validate html view is displayed on Support page")]
        public void ThenValidateHtmlViewIsDisplayedOnSupportPage()
        {
            bool isButtonDisplayed = buttons.supporthtmlpage();
            Assert.IsTrue(isButtonDisplayed, "The validate html view is not displayed on support page");
        }

        [Then(@"validate page title is displayed on Support page")]
        public void ThenValidatePageTitleIsDisplayedOnSupportPage()
        {
            string expectedTitle = "Support";
            string actualTitle = buttons.titlepagesupport();
            Assert.AreEqual(expectedTitle, actualTitle, "validate title is not support page");
        }

        [When(@"I press back from Support page")]
        public void WhenIPressBackFromSupportPage()
        {
            buttons.pressbacksupportpage();
        }

        [Then(@"I press menu item Home on bottom ribbon bar")]
        public void ThenIPressMenuItemHomeOnBottomRibbonBar()
        {
            buttons.homebackpage();
        }


    }
}
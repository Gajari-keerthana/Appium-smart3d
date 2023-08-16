using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowProject2.Utility;
using OpenQA.Selenium;

namespace SpecFlowProject2.Pages
{
    public class Ribbonbar : Buttons
    {
        private AppiumDriver<AndroidElement> driver;
        public Ribbonbar()
        {
            this.driver = module._driver;
        }

        //press Music program on the top ribbon bar
        By ribbon = By.XPath("//android.widget.ImageView[@content-desc=\"prg_music_m\"]");

        public void topribbon()
        {
            Controlhelper.ButtonClick(ribbon);
        }

        By topoutdoor = By.XPath("//android.widget.ImageView[@content-desc=\"prg_outdoor_m\"]");

        public void topoutribbon1()
        {
            Controlhelper.ButtonClick(topoutdoor);
        }

        By tophear = By.XPath("//android.widget.ImageView[@content-desc=\"prg_hearinnoise_m\"]");

        //press Hear in noise program on the top ribbon bar
        public void tophearribbon2()
        {
            Controlhelper.ButtonClick(tophear);
        }

        By topAllaround = By.XPath("//android.widget.ImageView[@content-desc=\"prg_allaround_m\"]");

        public void topAllaroundribbon3()
        {
            Controlhelper.ButtonClick(topAllaround);
        }

        //press Program overview button on topribbonbar
        By programoverview = By.XPath("//android.widget.ImageView[@content-desc=\"ProgramOverviewDragButton\"]");

        public void programdrag()
        {
            Controlhelper.ButtonClick(programoverview);
        }

        //press Hear in noise program on Program overview
        By hearoverview = By.XPath("//android.widget.ImageView[@content-desc=\"prg_hearinnoise_m\"]");
        public void programhear()
        {
            Controlhelper.ButtonClick(hearoverview);
        }

        //press Outdoor program on Program overview
        By outdoorreview = By.XPath("//android.widget.ImageView[@content-desc=\"prg_outdoor_m\"]");
        public void programoutdoor()
        {
            Controlhelper.ButtonClick(outdoorreview);
        }

        //press Music program on Program overview
        By musicreview = By.XPath("//android.widget.ImageView[@content-desc=\"prg_music_m\"]");
        public void programmusic()
        {
            Controlhelper.ButtonClick(musicreview);
        }

        //press All-Around program on Program overview
        By Allaroundreview = By.XPath("//android.widget.ImageView[@content-desc=\"prg_allaround_m\"]");
        public void programAllaround()
        {
            Controlhelper.ButtonClick(Allaroundreview);
        }

        //press the Close button on Program overview
        By close = By.XPath("//android.widget.ImageView[@content-desc=\"icon_close_m\"]");
        public void programclose()
        {
            Controlhelper.ButtonClick(close);
        }

        //press menu item My ReSound on bottom ribbon bar
        By Myresound = By.XPath("//android.widget.ImageView[@content-desc=\"bottom_menu_icon_person\"]");
        public void resound()
        {
            Controlhelper.ButtonClick(Myresound);
        }


    }
}

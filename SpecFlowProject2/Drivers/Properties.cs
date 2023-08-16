
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Remote;
using SpecFlowProject2.Utility;

namespace SpecFlowProject2.Drivers
{
    public class Properties
    {
        public static AppiumDriver<AndroidElement> driver;
        public static AppiumLocalService _appiumlocalService;

        public static AppiumDriver<AndroidElement> GetDriver()
        {
            if(driver == null)
            {
                StartAppiumServer();
                InitializeDriver();
            }
            return driver;
        }

        private static void StartAppiumServer()
        {
            //Start the Appium server
            _appiumlocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            _appiumlocalService.Start();
        }

        public  static void InitializeDriver()
        {
            
            var appiumOptions = new AppiumOptions();

            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("platformVersion", "13");
            appiumOptions.AddAdditionalCapability("deviceName", "R5CT31BHYWE");
            appiumOptions.AddAdditionalCapability("automationName", "UiAutomator2");
            appiumOptions.AddAdditionalCapability("appium:appiumServerAddress", "http://127.0.0.1:4723/wd/hub");
            appiumOptions.AddAdditionalCapability("appPackage", "dk.resound.smart3d");
            
            appiumOptions.AddAdditionalCapability(CapabilityType.Timeouts, TimeSpan.FromSeconds(20)); 

            appiumOptions.AddAdditionalCapability("app", "C:/Users/I-Ray/AppData/Local/Android/Sdk/platform-tools/dk.resound.smart3d-Signed.apk");
            appiumOptions.AddAdditionalCapability("androidInstallTimeout", 120000);
            appiumOptions.AddAdditionalCapability("permissions", "permission1,permission2");
            // Add more Appium options as needed

            var httpClient = new HttpClient(); 
            httpClient.Timeout = TimeSpan.FromSeconds(120);
            var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(120)); 

            driver = new AndroidDriver<AndroidElement>(_appiumlocalService, appiumOptions);
            module._driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            
            

        }

        public static void QuitDriver()
        {
            if(driver != null)
            {
                driver.Quit();
                driver.Dispose();

            }
            if(_appiumlocalService != null)
            {
                _appiumlocalService.Dispose();
                _appiumlocalService = null;
            }
        }
       

    }
}



using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace AppiumCTest
{
    public class TC1
    {
        [Test]
        public void InitDriver()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("deviceName", "Pixel 3a");
            capabilities.SetCapability("udid", "93KAY0C8KD");
           // capabilities.SetCapability("appPackage", "com.google.android.calculator");
            var driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.01:4723/wd/hub"), capabilities);

            driver.FindElement(By.XPath("//android.widget.ImageButton[@content-desc=\'7\']")).Click();
            driver.FindElement(By.Id("com.google.android.calculator:id/op_add")).Click();
            driver.FindElement(By.Id("com.google.android.calculator:id/digit_9")).Click();
            driver.FindElement(By.Id("com.google.android.calculator:id/eq")).Click();

            //var check = driver.FindElement(By.Id("com.google.android.calculator:id/result_preview")).Text;
            ////Assert.IsNotNull(driver);
            //Assert.AreEqual("16",check);

            Thread.Sleep(2000);
        }
    }
}

using System.Globalization;
using Microsoft.VisualBasic;
using OpenQA.Selenium.Chrome;
using SeleniumDotNetAutomation.Framework.Utils;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace SeleniumDotNetAutomation.Tests.Tests.Sandbox;

[TestClass]
public class UnitTest1 : TestFixture
{

    [TestMethod]
    public void MathTest()
    {
        Console.WriteLine(Math.Ceiling(1.1));
    }

    [TestMethod]
    public void TestSelenium()
    {
        Driver.Navigate().GoToUrl("https://www.emirates.com/ae/english/");
        Driver.Manage().Window.Maximize();
    }

    [TestMethod]
    public void NetworkManagerTest()
    {
       ChromeDriverService svc = ChromeDriverService.CreateDefaultService();
       var driver = new ChromeDriver(svc);
       NetworkMonitoring monitor = new NetworkMonitoring(driver);
       monitor.Start();
       driver.Navigate().GoToUrl("https://www.google.com");
       monitor.Stop();
       var allResponses = monitor.Responses;
       Assert.IsTrue(allResponses.Count > 0, "Network request were not captured.");
       driver.Quit();
    }

    [TestMethod]
    public void DateTimeTest()
    {

        UserData user = new()
        {
            TimezoneId = 50
        };

        var now = DateTime.Now;

        Console.WriteLine("Local Time: " + now.ConvertToString(DateTimeFormat.Iso8601));
        Console.WriteLine("UTC: " + now.ConvertToAnotherTimezone().ToString());
        var userPreferredTzDt = now.ConvertToAnotherTimezone(user.GetTimezone().ToTimeZoneInfo());
        Console.WriteLine("User-Preferred: " + userPreferredTzDt.ToString());
        Console.WriteLine("=====Testing from String Conversion=====");
        var fromString = userPreferredTzDt.ConvertToString();
        Console.WriteLine("Converted from String (Timezone Unspecified): " + fromString);
        Console.WriteLine("=====Testing from String Conversion=====");
        var dateTimeFromString = fromString.ConvertToDateTime(DateTimeFormat.Milliseconds);
        Console.WriteLine("DateTime From String (Unspecified Timezone): " + dateTimeFromString.ConvertToString(DateTimeFormat.Iso8601));
    }

    
}
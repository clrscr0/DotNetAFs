using OpenQA.Selenium;

public class SearchFlightComponent
{
    private IWebDriver _driver;
    public SearchFlightComponent(IWebDriver driver)
    {
        this._driver = driver;
    }
}
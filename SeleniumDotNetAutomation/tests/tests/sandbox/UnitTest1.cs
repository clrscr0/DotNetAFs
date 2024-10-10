using NLog;
using SeleniumDotNetAutomation.framework.utilities.WebDriverExtensions.ExtendedFindElement;

namespace SeleniumDotNetAutomation;

[TestClass]
public class UnitTest1
{
     
    [TestMethod]
    public void TestMethod1()
    {

        ElementWebDriverExtension.ExtendedFindElement();
        
    }

    [TestMethod]
    public void TestMethod2()
    {
        
    }
}
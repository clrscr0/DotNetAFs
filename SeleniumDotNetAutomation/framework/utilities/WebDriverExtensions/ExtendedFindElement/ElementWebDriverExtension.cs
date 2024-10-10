using NLog;

namespace SeleniumDotNetAutomation.framework.utilities.WebDriverExtensions.ExtendedFindElement
{
    public class ElementWebDriverExtension
    {
         private static Logger logger = LogManager.GetCurrentClassLogger();
    
        public static void ExtendedFindElement(ExtendedFindElementConfig? config = null)
        {
            if (config == null) config = new ExtendedFindElementConfig();

            Console.WriteLine($"CONFIG: {config}");
        }
    }
}
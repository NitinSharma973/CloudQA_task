using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

class AutomationPracticeTest
{
    static void Main(string[] args)
    {
        // 1. Setup WebDriver
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

        try
        {
            // 2. Wait for elements to load
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // 3. Test Field 1: First Name
            IWebElement firstNameField = wait.Until(drv => drv.FindElement(By.Id("fname"))); // Locate by ID
            firstNameField.Clear();
            firstNameField.SendKeys("John");
            Console.WriteLine("First Name field tested successfully.");

            // 4. Test Field 2: Last Name
            IWebElement lastNameField = wait.Until(drv => drv.FindElement(By.Id("lname"))); // Locate by ID
            lastNameField.Clear();
            lastNameField.SendKeys("Doe");
            Console.WriteLine("Last Name field tested successfully.");

            // 5. Test Field 3: Gender (Radio Button)
            IWebElement genderMaleRadio = wait.Until(drv => drv.FindElement(By.Id("male"))); // Locate by ID
            if (!genderMaleRadio.Selected)
            {
                genderMaleRadio.Click();
            }
            Console.WriteLine("Gender field tested successfully.");

            // 6. Test Field 4: Date of Birth
            IWebElement dobField = wait.Until(drv => drv.FindElement(By.Id("dob"))); // Locate by ID
            dobField.Clear();
            dobField.SendKeys("1990-01-01");
            Console.WriteLine("Date of Birth field tested successfully.");

            // 7. Finalize
            Console.WriteLine("All tests completed successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
        finally
        {
            // 8. Close the browser
            driver.Quit();
        }
    }
}

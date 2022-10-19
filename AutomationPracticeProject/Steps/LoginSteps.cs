using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AutomationPracticeProject.Steps
{
    [Binding]
    public class LoginSteps
    {
        public IWebDriver driver;

        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            driver = new ChromeDriver();
            driver.Url = "http://automationpractice.com/index.php";
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            driver.FindElement(By.XPath("//a[@class='login']")).Click();
        }
        
        [When(@"User enter UserName and Password")]
        public void WhenUserEnterUserNameAndPassword()
        {
            driver.FindElement(By.Id("email")).SendKeys("siva.bojja143@gmail.com");
            driver.FindElement(By.Id("passwd")).SendKeys("sivabojja@1234#");
        }
        
        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            driver.FindElement(By.Id("SubmitLogin")).Click();
        }
        
        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            Console.WriteLine("Successful Login");
        }
    }
}

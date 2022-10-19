using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace AutomationPracticeProject.Steps
{
    [Binding]
    public class RegisterSteps
    {
        public IWebDriver driver;

        [Given(@"User is at the AutoMation Practice Home Page")]
        public void GivenUserIsAtTheAutoMationPracticeHomePage()
        {
            driver = new ChromeDriver();
            driver.Url = "http://automationpractice.com/index.php";
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"Navigate to SignIn Page")]
        public void GivenNavigateToSignInPage()
        {
            driver.FindElement(By.XPath("//a[@class='login']")).Click();
        }
        
        [When(@"User given at valid Email address")]
        public void WhenUserGivenAtValidEmailAddress()
        {
            driver.FindElement(By.Id("email_create")).SendKeys("siva.bojja143@gmail.com");
        }
        
        [When(@"Click on the Create an account Button")]
        public void WhenClickOnTheCreateAnAccountButton()
        {
            driver.FindElement(By.Id("SubmitCreate")).Click();
        }
        
        [When(@"User fill the Register Form")]
        public void WhenUserFillTheRegisterForm()
        {
            driver.FindElement(By.XPath("//*[@id='id_gender1']")).Click();
            driver.FindElement(By.Id("customer_firstname")).SendKeys("siva");
            driver.FindElement(By.Id("customer_lastname")).SendKeys("bojja");
            driver.FindElement(By.Id("passwd")).SendKeys("sivabojja@1234#");
            SelectElement selectdate = new SelectElement(driver.FindElement(By.CssSelector("#days")));
            selectdate.SelectByValue("21");
            SelectElement selectmonth = new SelectElement(driver.FindElement(By.CssSelector("#months")));
            selectmonth.SelectByValue("10");
            SelectElement selectyear = new SelectElement(driver.FindElement(By.CssSelector("#years")));
            selectyear.SelectByValue("1991");
            driver.FindElement(By.Id("uniform-newsletter")).Click();
            driver.FindElement(By.Id("optin")).Click();
            //driver.FindElement(By.Id("firstname")).SendKeys("siva");
            //driver.FindElement(By.Id("lastname")).SendKeys("bojja");
            driver.FindElement(By.Id("company")).SendKeys("I-Ray Solutions");
            driver.FindElement(By.Id("address1")).SendKeys("Hive space 3rd Floor Kondapur");
            driver.FindElement(By.Id("address2")).SendKeys("Google Opposite 3rd floor");
            driver.FindElement(By.Id("city")).SendKeys("Hyderabad");
            SelectElement selectState = new SelectElement(driver.FindElement(By.CssSelector("#id_state")));
            selectState.SelectByValue("14");
            driver.FindElement(By.Id("postcode")).SendKeys("56789");
            SelectElement selctCountry = new SelectElement(driver.FindElement(By.CssSelector("#id_country")));
            selctCountry.SelectByValue("21");
            driver.FindElement(By.Id("other")).SendKeys("This is siva bojja");
            driver.FindElement(By.Id("phone")).SendKeys("7386084377");
            driver.FindElement(By.Id("phone_mobile")).SendKeys("9704556006");
        }

        [When(@"User click the Register Button")]
        public void WhenUserClickTheRegisterButton()
        {
            driver.FindElement(By.Id("submitAccount")).Click();
        }
        
        [Then(@"Register message should display")]
        public void ThenRegisterMessageShouldDisplay()
        {
            Console.WriteLine("Registration Succeessfully");
        }
    }
}

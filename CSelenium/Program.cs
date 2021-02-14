using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace CSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            string site = @"https://www.gittigidiyor.com/";
            driver.Navigate().GoToUrl(site);


            //driver.FindElement(By.CssSelector("span.profile.name")).Click(); ;

            string giris = @"https://www.gittigidiyor.com/uye-girisi";
            driver.Navigate().GoToUrl(giris);


            driver.FindElement(By.Id("L-UserNameField")).SendKeys("ozkbraa@gmail.com");
            driver.FindElement(By.Id("L-PasswordField")).SendKeys("ozkubra54");
            driver.FindElement(By.Id("gg-login-enter")).Click();

            //driver.FindElement(By.Name("k")).SendKeys("bilgisayar");
            driver.FindElement(By.CssSelector("input[name=k]")).SendKeys("bilgisayar");
            driver.FindElement(By.ClassName("hKfdXF")).Click();


            //driver.FindElement(By.ClassName("gg-d-24"));

            //driver.FindElement(By.LinkText("2")).Click(); ;

            
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,8950);");
            //Console.Read();
            //js.ExecuteScript("window.scrollTo (0, document.body.scrollHeight)");
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//a[text()='2']")).Click();


            js.ExecuteScript("window.scrollBy(0,350);");
            Thread.Sleep(5000);


            driver.FindElement(By.XPath("/html/body/div[5]/div[2]/div/div[2]/div[3]/div[2]/ul/li[2]/a/div/div/div[1]/div[1]/h3/span")).Click();


            Thread.Sleep(8000);
            js.ExecuteScript("window.scrollBy(0,150);");

            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div[1]/div[2]/div[2]/div[1]/div/div[3]/div[2]/section/div/div/div[2]/form/button")).Click();
            Thread.Sleep(2000);

          

            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[4]/div[3]/div/a")).Click();

            Thread.Sleep(2000);

            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[1]/form/div/div[2]/div[2]/div/div[2]/div[6]/div[2]/div[2]/div[4]/div/div[2]/select/option[2]")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[1]/form/div/div[2]/div[2]/div/div[2]/div[6]/div[2]/div[2]/div[3]/div/div[2]/div/a")).Click();

            Thread.Sleep(2000);

            
        }
    }
}

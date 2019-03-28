using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.naver.com/";
            driver.Manage().Window.Maximize();
            /*
            Thread.Sleep(500);

            driver.FindElement(By.XPath("//*[@id='account']/div/a/i")).Click();
            Thread.Sleep(500);
         
            driver.FindElement(By.Id("id")).SendKeys("a");
            Thread.Sleep(500);
            driver.FindElement(By.Id("pw")).SendKeys("a");
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id='frmNIDLogin']/fieldset/input")).Click();
            
            Thread.Sleep(500);
            driver.Navigate().Back();
            *//*
             //구글 로그인
            driver.FindElement(By.XPath("//*[@id='gb_70']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("identifierId")).SendKeys("xoals5566@gmail.com");
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id='identifierNext']/content/span")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("비밀번호*");
            Thread.Sleep(1500);
            driver.FindElement(By.XPath("//*[@id='passwordNext']/content/span")).Click();
            */
            /* driver.Navigate().Back();
            // driver.Navigate().Forward();
            // driver.Navigate().Refresh();
             Thread.Sleep(10000);
             driver.FindElement(By.Id("id")).SendKeys("taemin5566");
             Thread.Sleep(1500);
             driver.FindElement(By.Id("pw")).SendKeys("비밀번호!");
             Thread.Sleep(1500);
             driver.FindElement(By.XPath("//*[@id='frmNIDLogin']/fieldset/input")).Click();
             Thread.Sleep(1000);
             */
            /*driver.Navigate().Back();
            
            Thread.Sleep(500);
            driver.FindElement(By.Id("id")).SendKeys("taemin5566");
            Thread.Sleep(500);
            driver.FindElement(By.Id("pw")).SendKeys("비밀번호!");
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id='frmNIDLogin']/fieldset/input")).Click();
            */
            /*
            IWebDriver driver = new InternetExplorerDriver();

            driver.Url = "https://www.facebook.com/";
            driver.Manage().Window.Maximize(); //브라우져 최대 확대

            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("alex@csharpstudy.com");
            driver.FindElement(By.Id("pass")).SendKeys("");
            driver.FindElement(By.Id("loginbutton")).Click();
            Thread.Sleep(5000);

            driver.Close();
            */
            IWebElement q = driver.FindElement(By.Id("query"));
            q.SendKeys("노래순위");
            driver.FindElement(By.Id("search_btn")).Click();
            Thread.Sleep(5000);

            var rank = driver.FindElement(By.ClassName("list_top_music"));
            // 1위 제목 출력
            string title;
            for (int i = 1; i <= 10; i++)
            {

                var rankOne = rank.FindElement(By.XPath("//*[@id='main_pack']/div[2]/div[2]/ol/li[" + i + "]/div/div[1]/div[2]/div[1]/a"));
                //*[@id="main_pack"]/div[2]/div[2]/ol/li[1]/div/div[1]/div[2]/div[2]/a[1]
                //*[@id="main_pack"]/div[2]/div[2]/ol/li[2]/div/div[1]/div[2]/div[1]/a
                //*[@id="main_pack"]/div[2]/div[2]/ol/li[2]/div/div[1]/div[2]/div[2]/a[1]
                //*[@id="main_pack"]/div[2]/div[2]/ol/li[3]/div/div[1]/div[2]/div[1]/a
                title = rankOne.Text;
                Console.WriteLine(title);
            }



        }
    }
}

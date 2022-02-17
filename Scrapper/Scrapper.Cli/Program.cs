using System;
using System.Linq;
using Asastra.Extensions.HtmlAgilityPack;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Scrapper.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            const string className = "hackdown-content";
            const string taskUrl = "https://www.hackerrank.com/challenges/list-comprehensions/problem?isFullScreen=true";

            // TODO: OCR text from svg ...

            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(taskUrl);

            var html = driver.FindElement(By.ClassName(className)).GetAttribute("innerHTML");

            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            var paragraphs = doc.DocumentNode.Descendants().Where(e => e.Name == "p");

            foreach (var p in paragraphs)
                Console.WriteLine(p.InnerText);
        }
    }
}

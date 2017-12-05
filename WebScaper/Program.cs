using System;
using HtmlAgilityPack;

namespace WebScaper
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDocument = new HtmlDocument();
            
            htmlDocument = htmlWeb.Load("https://news.ycombinator.com/");

            if (htmlDocument.DocumentNode != null)
            {
                HtmlNodeCollection articles = htmlDocument.DocumentNode.SelectNodes("//a[@class='storylink']");

                foreach (HtmlNode node in articles)
                    Console.WriteLine(node.InnerText);
            }
        }
    }
}
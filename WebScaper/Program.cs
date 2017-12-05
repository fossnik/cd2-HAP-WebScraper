using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
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

            if (htmlDocument.DocumentNode == null)
                Console.WriteLine("null document node!");
            
            var articles = htmlDocument.DocumentNode.SelectNodes("//a[@class='storylink']");

            foreach (HtmlNode node in articles)
                Console.WriteLine(node.InnerText);
        }
    }
}
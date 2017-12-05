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
//            HtmlWeb htmlWeb = new HtmlWeb();
//            HtmlDocument htmlDocument = htmlWeb.Load("https://news.ycombinator.com/");

            const string filePath = @"/home/seth/careerDevs-i/RiderProjects/WebScaper/HackerNews.htm";
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.Load(filePath);
            
            if (htmlDocument.DocumentNode == null)
                Console.WriteLine("null document node!");
            
            Console.WriteLine(htmlDocument.DocumentNode.InnerHtml);

//            var articles = htmlDocument.DocumentNode.SelectNodes("//a[@class='storylink']//a");
//
//            foreach (HtmlNode node in articles)
//            {
//                Console.WriteLine(node.ChildNodes[0].InnerHtml);
//            }
        }
    }
}
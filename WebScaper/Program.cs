using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace WebScaper
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDocument = htmlWeb.Load("https://news.ycombinator.com/");
            
            HtmlWeb htmlWeb = new HtmlWeb() {
            
            //scrapysharp
//            var headerNames - DoubleConverter.DocumentNode.Selectnodes("//table[@class='bars']");
        }
    }
}
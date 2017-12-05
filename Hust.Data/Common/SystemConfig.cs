using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace Hust.Data.Common
{
    public static class SystemConfig
    {
        public static string AppDomain = ConfigurationManager.AppSettings["domain"];

        public static string UserSession = "username";

        public static long TimeToken = 7 * TimeSpan.TicksPerDay;

        public static string GetIpv4()
        {
            var web = new HtmlWeb();
            var doc = web.Load("https://cmyip.com/");
            var ip = doc.DocumentNode.SelectSingleNode("/html/body/div[2]/div/h1");
            if (ip != null)
            {
                return ip.InnerText
                    .Replace("My IP Address is", "").Replace("Hide IP Address", "").TrimStart().TrimEnd();
            }
            return "";
        }
    }
}
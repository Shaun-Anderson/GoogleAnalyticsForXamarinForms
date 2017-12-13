using System;
using System.Collections.Generic;
using System.Runtime;
using System.Runtime.InteropServices;
using Plugin.GoogleAnalytics;

namespace TestConsoleApplication
{
    public class Program
    {
        private static void Main(string[] args)
        {
            GoogleAnalytics.Current.Config.TrackingId = "UA-111100189-1";
            GoogleAnalytics.Current.Config.AppId = "TestAccount";
            GoogleAnalytics.Current.Config.AppName = "TestApp";
            GoogleAnalytics.Current.Config.AppInstallerId = Guid.NewGuid().ToString();
            GoogleAnalytics.Current.Tracker.UserAgentOverride = "dfsfsdf";

            //GoogleAnalytics.Current.Config.Debug = true;
            GoogleAnalytics.Current.InitTracker();
            Console.WriteLine("Started...");

            try
            {
                GoogleAnalytics.Current.Tracker.SendView("MainPage");
                Console.WriteLine("Sending View");
                GoogleAnalytics.Current.Tracker.SendEvent("Category", "Action", "Label", 1);
                Console.WriteLine("Sending Event");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending data: " + ex);
            }

            Console.ReadLine();
        }

        private static void Tets2()
        {
            //GA.Config.TrackingId = "UA-1111111";

            //GA.Tracker.SendEvent("sdfdsf");
        }
    }
}
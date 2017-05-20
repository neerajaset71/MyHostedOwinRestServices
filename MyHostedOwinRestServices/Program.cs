using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Owin.Hosting;

namespace MyHostedOwinRestServices
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:8080/";

            //Start Owin Host
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Service Started : Hosted at " + baseAddress);
                Thread.Sleep(-1);
            }
        }
    }
}

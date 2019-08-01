using System;
using System.Diagnostics;
using System.Net;

namespace lab_63_webstreaming
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();
            GetPageSync();
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);

            var t = new Stopwatch();
            t.Start();
            GetWebPagesAsync();
            t.Stop();
            Console.WriteLine(t.ElapsedMilliseconds);
            //read a web page
            /*Uri albahari = new Uri("http://www.albahari.com/nutshell/code.aspx");

            //URI uniform resource IDENTIFIER - more general 
            //URL uniform resource LOCATOR - more specific

            Console.WriteLine(albahari.Host);
            Console.WriteLine(albahari.Port);
            Console.WriteLine(albahari.AbsolutePath);

            //download this file
            var downloadwebpage01 = new WebClient { Proxy = null };

            
            downloadwebpage01.DownloadFile(albahari, "albahari.html");

            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "albahari.html");*/


        }

        static void GetPageSync()
        {
            Uri albahari = new Uri("http://www.albahari.com/nutshell/code.aspx");

            var downloadwebpage01 = new WebClient { Proxy = null };

            downloadwebpage01.DownloadFile(albahari, "albahari.html");

            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "albahari.html");

        }

        async static void GetWebPagesAsync()
        {
            Uri albahari = new Uri("http://www.albahari.com/nutshell/code.aspx");

            var downloadwebpage01 = new WebClient { Proxy = null };
            
             await downloadwebpage01.DownloadFileTaskAsync(albahari, "albahari.html");

            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "albahari.html");

        }

        //note : web client
        //note : http request/ response give more detail / prefered to use
    }
}

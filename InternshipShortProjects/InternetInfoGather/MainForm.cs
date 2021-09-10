using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


//IMPORTANT: might be able to do it without threads(and might be better) video: https://www.youtube.com/watch?v=2moh18sh5p4
//The video above includes everything except for the linear parallel

//ADVANCED: https://www.youtube.com/watch?v=ZTKGRJy5P2M
//The video above includes a cancel button(haven't watched it)

namespace InternetInfoGather
{
    public partial class MainForm : Form
    {

        public static List<string> websites = new List<string>()
        {
            "https://www.google.com",
            "https://www.microsoft.com",
            "https://www.cnn.com",
            "https://www.amazon.com",
            "https://www.facebook.com",
            "https://www.twitter.com",
            "https://www.codeproject.com",
            "https://www.stackoverflow.com",
            "https://en.wikipedia.org/wiki/.NET_Framework",
            "https://nakov.com",
            "https://elmah.io",
            "https://www.pluralsight.com",
            "https://www.udemy.com"
        };

        private static WebsiteDataModel DownloadWebsiteOriginal(string websiteUrl)
        {
            WebsiteDataModel result = new WebsiteDataModel();
            result.WebsiteUrl = websiteUrl;

            WebClient webClient = new WebClient();
            result.WebsiteData = webClient.DownloadString(websiteUrl);

            return result;
        }

        private async static Task<WebsiteDataModel> DownloadWebsiteAsync(string websiteUrl)
        {
            WebsiteDataModel result = new WebsiteDataModel();
            result.WebsiteUrl = websiteUrl;

            WebClient webClient = new WebClient();
            result.WebsiteData = await webClient.DownloadStringTaskAsync(websiteUrl);

            return result;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNormalLinear_Click(object sender, EventArgs e)
        {
            RunNormal();
        }

        private void btnParallelLinear_Click(object sender, EventArgs e)
        {
            RunParallel();
        }

        private async void btnNormalAsync_Click(object sender, EventArgs e)
        {
            await RunAsync();
        }

        private async void btnParallelAsync_Click(object sender, EventArgs e)
        {
            await RunParallelAsync();
        }

        private void RunNormal()
        {
            StringBuilder testResultString = new StringBuilder();
            foreach (string websiteUrl in websites)
            {
                WebsiteDataModel website = DownloadWebsiteOriginal(websiteUrl);
                AddToStringBuilder(website, testResultString);
            }
            tboxTest.Text += testResultString.ToString();
        }

        //index out of range exception for some reason??? (on the line where we add new threads)
        //IMPORTANT: the method is very messy and probably bad practice/logic probably need to rethink it
        //would be happy to receive some advice from you
        private void RunParallel()
        {
            List<StringBuilder> testStrings = new List<StringBuilder>();
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < websites.Count; i++)
            {
                testStrings.Add(new StringBuilder());
                AddToStringBuilder(DownloadWebsiteOriginal(websites[i]), testStrings[i]);///
                //threads.Add(new Thread(() => AddToStringBuilder(DownloadWebsiteOriginal(websites[i]), testStrings[i])));
                threads.Add(new Thread(new ThreadStart(() => AddToStringBuilder(DownloadWebsiteOriginal(websites[i]), testStrings[i]))));
                threads[i].Start();
            }
            StringBuilder testResultString = new StringBuilder();
            foreach (StringBuilder stringBuilder in testStrings)
            {
                testResultString.Append(stringBuilder.ToString());
            }
            tboxTest.Text = testResultString.ToString();
        }

        private async Task RunAsync()
        {
            StringBuilder testResultString = new StringBuilder();
            foreach (string websiteUrl in websites)
            {
                //WebsiteDataModel website = await Task.Run(() => DownloadWebsiteOriginal(websiteUrl));
                WebsiteDataModel website = await DownloadWebsiteAsync(websiteUrl);
                AddToStringBuilder(website, testResultString);
            }
            tboxTest.Text += testResultString.ToString();
        }

        private async Task RunParallelAsync()
        {
            StringBuilder testResultString = new StringBuilder();
            List<Task<WebsiteDataModel>> websiteTasks = new List<Task<WebsiteDataModel>>();

            foreach (string websiteUrl in websites)
            {
                //websiteTasks.Add(Task.Run(() => DownloadWebsiteOriginal(websiteUrl)));
                websiteTasks.Add(DownloadWebsiteAsync(websiteUrl));

            }
            //tboxTest.Text += testResultString.ToString();
            WebsiteDataModel[] taskResults = await Task.WhenAll(websiteTasks);

            foreach (var result in taskResults)
            {
                AddToStringBuilder(result, testResultString);
            }
            tboxTest.Text += testResultString.ToString();
        }

        private void AddToStringBuilder(WebsiteDataModel website, StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine();
            stringBuilder.AppendLine(website.WebsiteUrl);
            //stringBuilder.AppendLine();
            stringBuilder.AppendLine(website.WebsiteData.Length.ToString());
            //stringBuilder.AppendLine($"{website.WebsiteUrl}{Environment.NewLine}{website.WebsiteData}{Environment.NewLine}");
        }
    }
}

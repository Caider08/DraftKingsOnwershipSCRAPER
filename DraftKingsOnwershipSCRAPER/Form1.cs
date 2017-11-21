using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using ScrapySharp.Network;
using ScrapySharp.Extensions;

namespace DraftKingsOnwershipSCRAPER
{
    public partial class GetPlayerTags : Form
    {
        DataTable table1;

        public WebBrowser webBroswer1 = new WebBrowser();

        

        public CookieContainer cookies2 = new CookieContainer();

        public CookieContainer GetCookieContainer()
        {
            CookieContainer container = new CookieContainer();

            foreach (string cookie in webBrowser1.Document.Cookie.Split(';'))
            {
                string name = cookie.Split('=')[0];
                string value = cookie.Substring(name.Length + 1);
                string path = "/";
                string domain = "https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends"; //change to your domain name
                container.Add(new Cookie(name.Trim(), value.Trim(), path, domain));
            }

            return container;
        }

        public GetPlayerTags()
        {
            InitializeComponent();
            this.webBrowser1.ObjectForScripting = new MyScript();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitTable()
        {
            DataTable table1 = new DataTable("PlayerTagsDataTable");
            table1.Columns.Add("Rank", typeof(int));
            table1.Columns.Add("Name", typeof(string));
            table1.Columns.Add("Tags", typeof(int));
            table1.Columns.Add("Salary", typeof(int));
            table1.Columns.Add("Start", typeof(int));
            table1.Columns.Add("Sit", typeof(int));

            playerTagsGridView.DataSource = table1;

        }

        private void GetPlayerTags_Load(object sender, EventArgs e)
        {
            InitTable();
            //var proxy = WebRequest.GetSystemWebProxy();
            WebProxy proxy1 = new WebProxy();
            proxy1.UseDefaultCredentials = false;

            //var webBrowser1 = new FSloginCookies();
            // webBrowser1.GetPage("https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends");

            //HtmlAgilityPack.HtmlDocument docu = webBrowser1.GetPage("https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends");

            using (CookieAwareWebClient client = new CookieAwareWebClient())
            {
                client.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;
                client.DownloadData("https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends");

                webBrowser1.Navigate("https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends");

                System.Threading.Thread.Sleep(5);

            }

           



            System.Threading.Thread.Sleep(5);

            //CookieContainer cookies = GetCookieContainer();

            // System.Diagnostics.Process.Start("https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends");


            //HtmlWeb web = new HtmlWeb();
            //HtmlAgilityPack.HtmlDocument weeksTags = await Task.Factory.StartNew(() => web.Load("https://stackoverflow.com/questions/23298532/htmlagilitypack-and-authentication"));
            //var node = weeksTags.DocumentNode.SelectNodes("//*[@id=\"question\"]/table//tr[1]/td[2]/div/div[2]/a[1]");
            //var innerTexts = node.Select(x => x.InnerText);
            //HtmlAgilityPack.HtmlDocument weeksTags = await Task.Factory.StartNew(() => web.Load("https://www.fansharesports.com/golf/analytics/tags", "GET",  proxy1, new NetworkCredential { UserName = "caiderwaider@hotmail.com", Password = "soccer08FS"}));
           // var node = weeksTags.DocumentNode.SelectNodes("//*[@id=\"DataTables_Table_0\"]//tr[1]/td[2]/a");
            

        }

        private void SiteLogIn_Click(object sender, EventArgs e)
        {
            // var client = new FSloginCookies();
            // HtmlAgilityPack.HtmlDocument clientDoc = client.GetPage("https://www.fansharesports.com/golf/trends");

            //var testid = clientDoc.GetElementbyId("main");

            //  var headertest = testid.NodeType;

            // var webBrowser1 = new FSloginCookies();
            // webBrowser1.Navigate("https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends");



            //System.Threading.Thread.Sleep(5);
            // HtmlAgilityPack.HtmlDocument docu = webBrowser1.Navigate("https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends");

            //System.Windows.Forms.HtmlDocument doc2 = webBroswer1.Document;

            

            //foreach (string cookie in doc2.Cookie.Split(';'))
           // {
                //string name = cookie.Split('=')[0];
                //string value = cookie.Substring(name.Length + 1);
                //string path = "/";
                //string domain = "https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends";
                //cookies2.Add(new Cookie(name.Trim(), value.Trim(), path, domain));
            //}

             var inputEmail = webBrowser1.Document.GetElementById("email");
             inputEmail.Focus();
             inputEmail.InnerText = "caiderwaider@hotmail.com";

             var inputPassword = webBrowser1.Document.GetElementById("password");
             inputPassword.Focus();
             inputPassword.InnerText = "DKscrape";

             var submit = webBrowser1.Document.GetElementById("submit");
             submit.InvokeMember("click");
             
            
         
            //webBrowser1.Navigate("https://www.fansharesports.com/shared/authenticate/credentials?redirectUrl=%2Fgolf%2Ftrends");

            //var fafabar = webBrowser1.Document.GetElementById("hdr-mobile-menu");
            //fafabar.InvokeMember("click");

           // var navBar = webBrowser1.Document.GetElementById("hdr-nav");

            //var navbar = navBar.GetElementsByTagName("ul");

           

          //  var links = navBar.GetElementsByTagName("a");

           // foreach(HtmlElement aS in links)
           // {
              //  if (aS.GetAttribute("href").Equals("/golf/analytics/tags"))
             //   {
                  
                   // aS.InvokeMember("click");
               // }
           // }

            System.Threading.Thread.Sleep(5);
            

            // var navbar = webBrowser1.Document.GetElementById("hdr-mobile-menu");

            //  var links = navbar.GetElementsByTagName("a");

            //  foreach (HtmlElement ele in links)
            // {
            // if (ele.GetAttribute("href").Equals("/golf/analytics/tags"))
            //  if (ele.InnerText.Equals("FanShare Pro"))
            //  {

            //  ele.InvokeMember("Click");
            // }
            // }

            //var fanSharePro = webBrowser1.Document.GetElementById("hdr-nav");

            //foreach (HtmlElement  in fanSharePro)
            //{

            // }

            // var navbar = webBrowser1.Document.GetElementById("hdr-nav");
            //var links = navbar.GetElementsByTagName("a");

            // foreach (HtmlElement ele in links)
            // {
            // if (ele.GetAttribute("href").Equals("/golf/analytics/tags"))
            // {

            // ele.InvokeMember("Click");
            // }
            // }


            //webBrowser1.Navigate("https://www.fansharesports.com/golf/analytics/tags");


        }

        private void navigate_Click(object sender, EventArgs e)
        {
            using ( CookieAwareWebClient client = new CookieAwareWebClient())
            {
                client.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;
                client.DownloadData("https://www.fansharesports.com/golf/trends");

                webBrowser1.Navigate("https://www.fansharesports.com/golf/analytics/tags");

                System.Threading.Thread.Sleep(5);
 
            }






            // webBroswer1.Navigate("https://www.fansharesports.com/golf/analytics/tags");

            //webBroswer1.Navigate("");

            //webBroswer1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(clickFilter);

            //void clickFilter(object sender2, WebBrowserDocumentCompletedEventArgs e2)
            // {
            //  var dataLength = ((WebBrowser)sender2).Document.GetElementById("DataTables_Table_0_length");

            // var options = dataLength.Document.GetElementsByTagName("option");




            //var options = select.GetElementsByTagName("option");

            //foreach (HtmlElement option in options)
            //{
            // if (option.GetAttribute("value").Equals(100))
            // {
            // option.Focus();
            //    option.InvokeMember("click");
            // }
            //}
            // }

            //System.Threading.Thread.Sleep(15);

            //  while (webBroswer1.Document.Body == null)
            // {
            //     Application.DoEvents();
            // }



            //System.Windows.Forms.HtmlDocument docu = webBroswer1.Document;



            // var dataLength = webBroswer1.Document.GetElementById("DataTables_Table_0_length");

            // var options = dataLength.Document.GetElementsByTagName("option");




            //var options = select.GetElementsByTagName("option");

            //  foreach (HtmlElement option in options)
            // {
            //  if (option.GetAttribute("value").Equals(100))
            //  {
            //      option.Focus();
            //      option.InvokeMember("click");
            //  }
            // }



            // System.Threading.Thread.Sleep(5);

            // System.Threading.Thread.Sleep(5);

            // var selectDIVwrapper = webBrowser1.Document.GetElementById("DataTables_Table_0_length");

            // var selectDiv = selectDIVwrapper.GetElementsByTagName("select");

            //var selector = selectDIV.GetElementsByTagName("select");


            //System.Threading.Thread.Sleep(5);

            // var tableGrab = webBrowser1.Document.GetElementsByTagName("tbody");


            // var table2Grab = webBrowser1.Document.GetElementById("dataTables_scrollBody");

            //var navbar = webBrowser1.Document.GetElementById("#hdr-mobile-menu");

            // var links = navbar.GetElementsByTagName("a");

            // foreach (HtmlElement ele in links)
            // {
            // if (ele.GetAttribute("href").Equals("/golf/analytics/tags"))
            //  if (ele.InnerText.Equals("FanShare Pro"))
            // {

            //   ele.InvokeMember("Click");
            //}
            //}

            System.Threading.Thread.Sleep(5);
        }

        private void ScrapySharpTest_Click(object sender, EventArgs e)
        {

           // webBroswer1.Navigate("https://www.fansharesports.com/golf");

            webBroswer1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(clickFilter);

            void clickFilter(object sender2, WebBrowserDocumentCompletedEventArgs e2)
            {
                
            }

            var dataLength = webBroswer1.Document.GetElementById("DataTables_Table_0_length");

            var options = dataLength.Document.GetElementsByTagName("option");




            //var options = select.GetElementsByTagName("option");

            foreach (HtmlElement option in options)
            {
                if (option.GetAttribute("value").Equals(100))
                {
                    option.Focus();
                    option.InvokeMember("click");
                }
            }






            System.Threading.Thread.Sleep(5);



          //  var client = new FSloginCookies();
            //HtmlAgilityPack.HtmlDocument clientDoc = client.GetPage("https://www.fansharesports.com/golf/trends");

            //var testid = clientDoc.GetElementbyId("main");

            //var headertest = testid.NodeType;

          //  System.Threading.Thread.Sleep(5);

            // ScrapingBrowser Browser = new ScrapingBrowser();
            // Browser.AllowAutoRedirect = true;
            // Browser.AllowMetaRedirect = true;

            // WebPage PageResult = Browser.NavigateToPage(new Uri("https://www.fansharesports.com/golf/trends"));
            // HtmlNode TestNode = PageResult.Html.CssSelect(".container").First();
            // string test = TestNode.InnerText;

            // webBrowser1.Navigate("https://www.fansharesports.com/golf/trends");

            //11.07.17

            //var tableGrab = webBrowser1.Document.GetElementsByTagName("tbody");


            //var table2Grab = webBrowser1.Document.GetElementById("dataTables_scrollBody");


        }

        private void BrowserTest_Click(object sender, EventArgs e)
        {
            //CookieBrowser b = new CookieBrowser();
            //  b.Get("https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends");
            // b.FormElements["email"] = "caiderwaider@hotmail.com";

            CookieBrowser b = new CookieBrowser();
            var testTrends = b.Get("https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends");
            //MessageBox.Show(testTrends);

            var countInputs = b.FormElements.Count();
            var firstInput = b.FormElements.Keys.Last();
            //MessageBox.Show(firstInput);

            b.FormElements["email"] = "caiderwaider@hotmail.com";
            b.FormElements["password"] = "DKscrape";

           

            var formInputCheck = b.FormElements["password"].ToString();
            //MessageBox.Show(formInputCheck);

            var response = b.Post("https://www.fansharesports.com/shared/authenticate/credentials?redirectUrl=%2Fgolf%2Ftrends");
           // MessageBox.Show(response);

            //MessageBox.Show(response);
            var response2 = b.Get2("https://www.fansharesports.com/golf/analytics/tags");

            //WORKING way down to Table via Divs
            var wrapperDiv = response2.DocumentNode.SelectSingleNode("//div[@id='content-wrap']");
            var mainDiv = response2.DocumentNode.SelectSingleNode("//div[@id='main']");
            var tableRow = mainDiv.SelectSingleNode("//*[@id='main']/div[2]");
            var tableMidDivs = tableRow.SelectSingleNode("//*[@id='main']/div[2]/div[2]");
            var tableTest = tableMidDivs.Elements("table").First();
            //var tableBody = tableTest.Elements("tbody").First();

            //var tableTry = response2.DocumentNode.SelectSingleNode("//tbody");

            //var tester = mainDiv.SelectSingleNode("//*[@id='DataTables_Table_0']");

            //var tableDiv = wrapperDiv.SelectSingleNode("//div[@id='DataTables_Table_0_wrapper']");
            //*[@id="DataTables_Table_0"];

            MessageBox.Show(tableTest.OuterHtml);

            //*[@id="DataTables_Table_0"]

            var htmlTextTest = response2.DocumentNode.InnerHtml;

            // MessageBox.Show(htmlTextTest);

            // var tableFind = response2.DocumentNode.CssSelect("DataTables_Table_0'").First();

            // var TableFindMore = tableFind.SelectNodes("//tr");

            //*[@id="DataTables_Table_0_wrapper"]/div[2]/div/div[1]/div[2]


            // var tableTest = response2.DocumentNode.SelectNodes("//*[@id='DataTables_Table_0']").First();
            //var tableTestRows = tableTest.SelectNodes(".//tr").ToArray();

            //var firstRow = tableTestRows.First();


            //MessageBox.Show(firstRow.GetType().ToString());




            System.Threading.Thread.Sleep(5);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CookieAwareWebClient client = new CookieAwareWebClient())
            {
                client.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;
                client.DownloadData("https://www.fansharesports.com/golf/trends");

                webBrowser1.Navigate("https://www.fansharesports.com/golf/analytics/tags");

                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                {
                    System.Threading.Thread.Sleep(5);

                }             
                //var dataLength = webBroswer1.Document.GetElementById("DataTables_Table_0_length");

                //var options = dataLength.Document.GetElementsByTagName("option");

                //webBroswer1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);

            }

            var dataLength = webBroswer1.Document.GetElementById("DataTables_Table_0_length");

            var options = dataLength.Document.GetElementsByTagName("option");




            //webBroswer1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(clickFilter);

            // void clickFilter(object sender2, WebBrowserDocumentCompletedEventArgs e2)
            //{

            // };



            //var docu = webBroswer1.Document;

            // var dataLength = docu.GetElementById("DataTables_Table_0_length");

            // var options = dataLength.Document.GetElementsByTagName("option");




            //var options = select.GetElementsByTagName("option");

            // foreach (HtmlElement option in options)
            // {
            // if (option.GetAttribute("value").Equals(100))
            //{
            //    option.Focus();
            //  option.InvokeMember("click");
            //}
            // }



            System.Threading.Thread.Sleep(5);
           


        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs events)
        {
            if (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                return;
            }

            else
            {
                var dataLength = webBroswer1.Document.GetElementById("DataTables_Table_0_length");

                string dataLengthText = dataLength.InnerHtml;

                MessageBox.Show(dataLengthText);

                var options = dataLength.Document.GetElementsByTagName("option");

                return;
            }
        }

        private void BrowserDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs events)
        {
            if (events.Url.AbsolutePath != ((WebBrowser)sender).Url.AbsolutePath)
                return;
            else
            {
                var dataLength = webBroswer1.Document.GetElementById("DataTables_Table_0_length");

                var options = dataLength.Document.GetElementsByTagName("option");

                System.Threading.Thread.Sleep(5);
            }

        }
    }
}

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

        public GetPlayerTags()
        {
            InitializeComponent();
            
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
        private async void GetPlayerTags_Load(object sender, EventArgs e)
        {
            InitTable();
            //var proxy = WebRequest.GetSystemWebProxy();
            WebProxy proxy1 = new WebProxy();
            proxy1.UseDefaultCredentials = false;

            webBrowser1.Navigate("https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends");

           // System.Diagnostics.Process.Start("https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends");


            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument weeksTags = await Task.Factory.StartNew(() => web.Load("https://stackoverflow.com/questions/23298532/htmlagilitypack-and-authentication"));
            var node = weeksTags.DocumentNode.SelectNodes("//*[@id=\"question\"]/table//tr[1]/td[2]/div/div[2]/a[1]");
            var innerTexts = node.Select(x => x.InnerText);
            //HtmlAgilityPack.HtmlDocument weeksTags = await Task.Factory.StartNew(() => web.Load("https://www.fansharesports.com/golf/analytics/tags", "GET",  proxy1, new NetworkCredential { UserName = "caiderwaider@hotmail.com", Password = "soccer08FS"}));
           // var node = weeksTags.DocumentNode.SelectNodes("//*[@id=\"DataTables_Table_0\"]//tr[1]/td[2]/a");
            

        }

        private void SiteLogIn_Click(object sender, EventArgs e)
        {
            var inputEmail = webBrowser1.Document.GetElementById("email");
            inputEmail.Focus();
            inputEmail.InnerText = "caiderwaider@hotmail.com";

            var inputPassword = webBrowser1.Document.GetElementById("password");
            inputPassword.Focus();
            inputPassword.InnerText = "soccer08FS";

            var submit = webBrowser1.Document.GetElementById("submit");
            submit.InvokeMember("click");

            System.Threading.Thread.Sleep(5);

            var fafabar = webBrowser1.Document.GetElementById("hdr-mobile-menu");
            fafabar.InvokeMember("click");


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

            webBrowser1.Navigate("https://www.fansharesports.com/golf/analytics/tags");


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
         }

        private void ScrapySharpTest_Click(object sender, EventArgs e)
        {
            ScrapingBrowser Browser = new ScrapingBrowser();
            Browser.AllowAutoRedirect = true;
            Browser.AllowMetaRedirect = true;

            WebPage PageResult = Browser.NavigateToPage(new Uri("https://www.fansharesports.com/golf/trends"));
            HtmlNode TestNode = PageResult.Html.CssSelect(".container").First();
            string test = TestNode.InnerText;

         
            
            

           // webBrowser1.Navigate("https://www.fansharesports.com/golf/trends");
            


        }

        
    }
}

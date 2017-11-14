using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftKingsOnwershipSCRAPER
{
    class CookieBrowser
    {
        private bool _isPost;
        private HtmlAgilityPack.HtmlDocument _htmlDoc;
        public CookieContainer cookieJar = new CookieContainer();

        public CookieCollection Cookies { get; set; }

        public FormElementCollection FormElements { get; set;  }

        public string Get(string url)
        {
            _isPost = false;
            CreateWebRequestObject().Load(url);
            return _htmlDoc.DocumentNode.InnerHtml;
           
        }

        public string Post(string url)
        {
            _isPost = true;
            CreateWebRequestObject().Load(url, "POST");
            return _htmlDoc.DocumentNode.InnerHtml;
        }

        private HtmlWeb CreateWebRequestObject()
        {
            HtmlWeb web = new HtmlWeb();
            web.UseCookies = true;
            web.PreRequest = new HtmlWeb.PreRequestHandler(OnPreRequest);
            web.PostResponse = new HtmlWeb.PostResponseHandler(OnAfterResponse);
            web.PreHandleDocument = new HtmlWeb.PreHandleDocumentHandler(OnPreHandleDocument);
            return web;
        }

        public bool OnPreRequest(HttpWebRequest request)
        {
            AddCookiesTo(request);
            //request.CookieContainer = cookieJar;
            if (_isPost)AddPostDataTo(request);
            return true;
        }



        protected void OnAfterResponse(HttpWebRequest request, HttpWebResponse response)
        {
            SaveCookiesFrom(response);
            //nothing
        }

        protected void OnPreHandleDocument(HtmlAgilityPack.HtmlDocument document)
        {
            SaveHtmlDocument(document);
        }

        private void AddPostDataTo(HttpWebRequest request)
        {
            string payload = FormElements.AssemblePostPayload();
            byte[] buff = Encoding.UTF8.GetBytes(payload.ToCharArray());
            request.ContentLength = buff.Length;
            request.ContentType = "application/x-www-form-urlencoded";
            System.IO.Stream reqStream = request.GetRequestStream();
            reqStream.Write(buff, 0, buff.Length);
        }

        /// <summary>
        /// Add cookies to the request object
        /// </summary>
        private void AddCookiesTo(HttpWebRequest request)
        {
            if (Cookies != null && Cookies.Count > 0)
            {
                request.CookieContainer.Add(Cookies);
            }
        }

        public string Get2(string url)
        {
            HtmlWeb web = new HtmlWeb();
            web.UseCookies = true;
            web.PreRequest = new HtmlWeb.PreRequestHandler(OnPreRequest2);
            web.PostResponse = new HtmlWeb.PostResponseHandler(OnAfterResponse2);
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            return doc.DocumentNode.InnerHtml;
        }

        public bool OnPreRequest2(HttpWebRequest request)
        {
            request.CookieContainer = cookieJar;
            return true;
        }

        protected void OnAfterResponse2(HttpWebRequest request, HttpWebResponse response)
        {
            //nothing
        }

        protected void SaveCookiesFrom(HttpWebResponse response)
        {
            if ((response.Cookies.Count > 0))
            {
                if (Cookies == null)
                {
                    Cookies = new CookieCollection();

                }

                Cookies.Add(response.Cookies);
                cookieJar.Add(Cookies);
            }
        }

        private void SaveHtmlDocument(HtmlAgilityPack.HtmlDocument document)
        {
            _htmlDoc = document;
            FormElements = new FormElementCollection(_htmlDoc);
        }


    }
}

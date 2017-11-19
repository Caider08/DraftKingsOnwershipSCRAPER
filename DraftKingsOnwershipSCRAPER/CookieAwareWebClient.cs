using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftKingsOnwershipSCRAPER
{
    class CookieAwareWebClient : WebClient
    {
        public CookieAwareWebClient()
        {
            CookieContainer cookiez = new CookieContainer();
        }

        public CookieContainer cookiez { get; set; }

        protected override WebRequest GetWebRequest (Uri address)
        {
            var request = base.GetWebRequest(address);
            var httpRequest = request as HttpWebRequest;
            if (httpRequest != null)
            {
                httpRequest.CookieContainer = cookiez;
            }

            return request;
        }
    }
}

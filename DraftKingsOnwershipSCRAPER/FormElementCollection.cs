﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace DraftKingsOnwershipSCRAPER
{
    class FormElementCollection : Dictionary<string, string>
    {

        
            /// <summary>
            /// Constructor. Parses the HtmlDocument to get all form input elements. 
            /// </summary>
            public FormElementCollection(HtmlAgilityPack.HtmlDocument htmlDoc)
            {
                var inputs = htmlDoc.DocumentNode.Descendants("input");
                foreach (var element in inputs)
                {
                    string name = element.GetAttributeValue("name", "undefined");
                    string value = element.GetAttributeValue("value", "");
                    //if (ContainsKey(name) & ContainsValue(value)) Remove(name);
                    if (!name.Equals("undefined") && !ContainsKey(name)) Add(name, value);
                    
                }
            }

            /// <summary>
            /// Assembles all form elements and values to POST. Also html encodes the values.  
            /// </summary>
            public string AssemblePostPayload()
            {
                StringBuilder sb = new StringBuilder();
                foreach (var element in this)
                {
                    string value = System.Web.HttpUtility.UrlEncode(element.Value);
                    sb.Append("&" + element.Key + "=" + value);
                }
                return sb.ToString().Substring(1);
            }
        
    }
}

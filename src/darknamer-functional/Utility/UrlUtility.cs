using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Utility
{
    public class UrlUtility
    {
        public static string QueryString(object jsonBody)
        {
            var json = JsonConvert.SerializeObject(jsonBody);
            var jObj = (JObject)JsonConvert.DeserializeObject(json);
            var queryString = string.Join("&",
                jObj.Children().Cast<JProperty>()
                    .Select(jp => jp.Name + "=" + System.Web.HttpUtility.UrlEncode(jp.Value.ToString())));
            // -- Debug.WriteLine("UrlUtil.QueryString(jsonBody = default(null)) = {0}", queryString); --
            return queryString;
        }
    }
}

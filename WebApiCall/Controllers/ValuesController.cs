using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;
using System.Net.Http;
using System.Web.Http;
using WebApiCall.Models;
using System.Text;
using System.ServiceModel.Channels;

namespace WebApiCall.Controllers
{
    public class ValuesController : ApiController
    {

        // GET api/values
        public String Get()
        {
            HttpWebRequest request = WebRequest.Create("https://api.logmycalls.com/services/getGroups?api_key=81cecd17ad914f7169316c092e9067c0&api_secret=%241%24XuMqIJB4%24LAfiIBxvbiQQ9VTf1ILC2.&sort_by=name&sort_order=asc") as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string vals = reader.ReadToEnd();
                reader.Close();
                response.Close();

                string val1 = "";
                if (vals != null)
                {
                    val1 = vals;
                }
                else
                {
                    val1 = "value2";
                }
                return val1;

            }
        }

        // GET api/values/5
        public String Get(int id)
        {
            HttpWebRequest request = WebRequest.Create("https://api.logmycalls.com/services/getCallDetails?criteria[ouid]="+id+"&api_key=81cecd17ad914f7169316c092e9067c0&api_secret=%241%24XuMqIJB4%24LAfiIBxvbiQQ9VTf1ILC2.&sort_by=id&sort_order=asc") as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string vals = reader.ReadToEnd();
                reader.Close();
                response.Close();

                string val1 = "";
                if (vals != null)
                {
                    val1 = vals;
                }
                else
                {
                    val1 = "value2";
                }
                return val1;
                
            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

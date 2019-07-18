using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab_09_api_demo.Controllers
{
    public class ValuesController : ApiController
    {

        static List<string> list01 = new List<string>()
        {
            // index number:
            //0        1       2        3       4
            "first","second","third","fourth","fifth"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return list01;
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            string returnData =  $"you requested data about the number {id}";
            returnData +=  $"-- the data you want is {list01[id]}";
            return returnData;
            //return "you want data about number" + id;
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

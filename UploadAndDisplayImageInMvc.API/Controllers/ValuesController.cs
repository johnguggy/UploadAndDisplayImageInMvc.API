using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UploadAndDisplayImageInMvc.Models;
using System.Data.Entity;

namespace UploadAndDisplayImageInMvc.API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public DBContext db = new DBContext();
        // GET api/values/5
        public string Get(int id)
        {
            string answer = db.Contents.Where(c => c.ID == id).Select(x => x.Description).First();
            return "Description = " + answer.ToString();
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

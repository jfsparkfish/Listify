using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Listify.Controllers
{
    public class ListifyController : ApiController
    {
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }


        public string Get(int start, int end, int id)
        {
            Listify list = new Listify(start, end);
            return list[id].ToString(); ;
        }
    }
    class Listify
    {
        private IEnumerable<int> stuff;

        public int this[int i] => stuff.ElementAt(i);

        public Listify(int start, int end)
        {
            int count = end - start;
            stuff = Enumerable.Range(start, count);
        }
    }
}
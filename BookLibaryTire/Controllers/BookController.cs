using ELL;
using ELL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookLibaryTire.Controllers
{
    public class BookController : ApiController
    {
        /*
        [Route("api/Product/All")]
        [HttpGet]
        public List<BookModel> GetAll()
        {
            return BookService.GetAll();
        }
        */
        [Route("api/Book/All")]
        [HttpGet]
        public List<BookModel> GetAll()
        {
            return BookService.GetAll();
        }
    }
}

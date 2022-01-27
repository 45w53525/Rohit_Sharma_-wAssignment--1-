using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {




        //GET localhost/Square/2 4
        //GET localhost/Square/-2 4
        // GET localhost/Square/10 10

        public int Get(int id)
        {
            return id *id;
        }





















    }








}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NewController : ApiController
    {


        //GET localhost/AddTen/21 31
        // GET localhost/AddTen/0 10
        // GET localhost/AddTen/-9 1

        public int Get(int id)
        {
            return id + 10;

        } 



      

        












    }


 }

    
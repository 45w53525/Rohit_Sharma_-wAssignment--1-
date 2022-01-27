using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class MathopController : ApiController
   {


        //  Request Response
        //GET localhost/NumberMachine/10 ?
        //GET localhost/NumberMachine/-5 ?
        //GET localhost/NumberMachine/30 ?



        public int Get(int id)
        {

            int Result = ( id * id + id-id) / 2;

            return   Result;


        }

















        }
}

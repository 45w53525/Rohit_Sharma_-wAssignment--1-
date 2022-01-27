using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class StringController : ApiController
    {



        // Request POST DATA Response
        // POST localhost/Greeting “Hello World!”


        public string post()
        {
          return "Hello World";

        }




        // Request Response
        //GET localhost/Greeting/3 Greetings to 3 people!
        // GET localhost/Greeting/6 Greetings to 6 
        //GET localhost/Greeting/0 Greetings to 0 people

        public string Get(int id)
        {
            String greeting = "Greeting to {id} people!";

            return greeting;


        }










    }


}












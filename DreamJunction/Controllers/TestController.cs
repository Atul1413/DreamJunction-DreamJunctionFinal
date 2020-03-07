using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DreamJunction.Controllers
{
    public class TestController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage RegisterInvestor()
        {
            try
            {
                //var seriptSerialization = new JavaScriptSerializer();
                //var response = Request.Content.ReadAsStringAsync();
                //var model = seriptSerialization.Deserialize<InvestorDetail>(response.Result);//Get Values For Request
                //_investorDetails.CreateInvestor(model);
                return Request.CreateResponse(System.Net.HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }
    }
}

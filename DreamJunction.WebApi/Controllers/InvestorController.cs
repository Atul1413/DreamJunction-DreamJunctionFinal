using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;
using DreamJunction.BLL.BusinessServicesInterfaces;
using DreamJunction.Entities;

namespace DreamJunction.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:51605/", headers: "*", methods: "*")]
    public class InvestorController : ApiController
    {
        private IInvestorDetails _investorDetails;
        public InvestorController(IInvestorDetails investorDetails)
        {
            _investorDetails = investorDetails;
        }
        [HttpPost]
        // [Route("api/InvestorController/RegisterInvestor")]
        public HttpResponseMessage RegisterInvestor()
        {
            try
            {
                var seriptSerialization = new JavaScriptSerializer();
                var response = Request.Content.ReadAsStringAsync();
                var model = seriptSerialization.Deserialize<InvestorDetail>(response.Result);//Get Values For Request
                _investorDetails.CreateInvestor(model);
                return Request.CreateResponse(System.Net.HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }
    }
}

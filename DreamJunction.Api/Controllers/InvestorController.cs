using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Net.Http;
using System.Web.Script.Serialization;
using DreamJunction.BLL.BusinessServicesInterfaces;
using DreamJunction.Entities;
using System.Net;

namespace DreamJunction.Api.Controllers
{
    public class InvestorController: ApiController
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
                return  Request.CreateResponse(HttpStatusCode.OK);
            }
        }
    }
}


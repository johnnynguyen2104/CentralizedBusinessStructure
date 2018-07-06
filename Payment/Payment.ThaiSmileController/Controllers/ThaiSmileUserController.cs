using AutoMapper;
using Payment.ThaiSmile.Dtos;
using Payment.ThaiSmile.Imps;
using Payment.ThaiSmile.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Payment.ThaiSmileController.Controllers
{
    [RoutePrefix("api")]
    public class ThaiSmileTransactionController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly IThaiSmileTransactionBusiness _tsTransactionBusiness;

        public ThaiSmileTransactionController(IMapper mapper, IThaiSmileTransactionBusiness tsTransactionBusiness)
        {
            _mapper = mapper;
            _tsTransactionBusiness = tsTransactionBusiness;
        }

        [HttpPost]
        [Route("TSTransaction")]
        public IHttpActionResult CreateTransaction(TransactionDto trans)
        {
            if (_tsTransactionBusiness.Create(trans))
            {
                return Ok("Transaction was Created");
            }

            return Content(HttpStatusCode.ExpectationFailed, "Fail to create.....");
        }

        [Route("TSTransaction")]
        public IHttpActionResult GetTransaction()
        {
            return Json(_tsTransactionBusiness.GetData<TransactionDto>());
        }
    }
}

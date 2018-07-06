using Autofac.Integration.WebApi;
using AutoMapper;
using Payment.NokAir.Dtos;
using Payment.NokAir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Payment.NokController.Controllers
{
    [RoutePrefix("api")]
    public class NokUserController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly INokTransactionBusiness _nokTransactionBusiness;

        public NokUserController(IMapper mapper, INokTransactionBusiness nokTransactionBusiness)
        {
            _mapper = mapper;
            _nokTransactionBusiness = nokTransactionBusiness;
        }

        [HttpPost]
        [Route("NokTransaction")]
        public IHttpActionResult CreateTransaction(TransactionDto trans)
        {
            if (_nokTransactionBusiness.Create(trans))
            {
                return Ok("Transaction was Created");
            }

            return Content(HttpStatusCode.ExpectationFailed, "Fail to create.....");
        }

        [Route("NokTransaction")]
        public  IHttpActionResult GetTransaction()
        {
            return Json(_nokTransactionBusiness.GetData<TransactionDto>());
        }
    }
}

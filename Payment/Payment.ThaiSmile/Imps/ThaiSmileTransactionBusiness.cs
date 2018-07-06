using AutoMapper;
using Payment.Core.Imps;
using Payment.Core.Interfaces;
using Payment.DAL.BaseEntities;
using Payment.DAL.DbContexts.ThaiSmile.Entities;
using Payment.DAL.Interfaces;
using Payment.ThaiSmile.Dtos;
using Payment.ThaiSmile.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.ThaiSmile.Imps
{
    public class ThaiSmileTransactionBusiness : UserBusiness<TSTransaction>, IThaiSmileTransactionBusiness
    {
        public ThaiSmileTransactionBusiness(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            
        }
    }
}

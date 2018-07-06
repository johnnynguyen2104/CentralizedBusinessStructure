using AutoMapper;
using Payment.Core.Imps;
using Payment.DAL.DbContexts.NokAir.Entities;
using Payment.DAL.Interfaces;
using Payment.NokAir.Interfaces;

namespace Payment.NokAir.Imps
{
    public class NokTransactionBusiness : UserBusiness<NokTransaction>, INokTransactionBusiness
    {
        //private readonly IUnitOfWork _unitOfWork;

        public NokTransactionBusiness(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}

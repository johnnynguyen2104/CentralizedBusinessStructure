using AutoMapper;
using Payment.Core.Dtos;
using Payment.Core.Interfaces;
using Payment.DAL.BaseEntities;
using Payment.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Payment.Core.Imps
{
    public class UserBusiness<TEntity> : ITransactionBusiness where TEntity : class
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserBusiness(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public virtual bool Create<TInputType>(TInputType user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("Couldn't create with null info.");
            }

            var userEntity = _mapper.Map<TEntity>(user);
            var result = _unitOfWork.Repository<TEntity>().Create(userEntity);

            return _unitOfWork.CommitChanges() > 0;
        }

        public IList<TReturn> GetData<TReturn>()
        {
            return _mapper.Map<IList<TReturn>>(_unitOfWork.Repository<TEntity>().Read(a => true));
        }
    }
}

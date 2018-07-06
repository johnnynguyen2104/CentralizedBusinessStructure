using Autofac;
using AutoMapper;
using Payment.DAL.BaseEntities;
using Payment.DAL.DbContexts.ThaiSmile;
using Payment.DAL.DbContexts.ThaiSmile.Entities;
using Payment.DAL.Interfaces;
using Payment.ThaiSmile.Dtos;
using Payment.ThaiSmile.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.ThaiSmile
{
    public class ThaiSmileMappingProfile : Profile
    {
        public ThaiSmileMappingProfile()
        {
            CreateMap<TSTransaction, TransactionDto>().ReverseMap();
        }
    }

    public class ThaiSmileIoCModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<ThaiSmile.Imps.ThaiSmileTransactionBusiness>()
                .As<IThaiSmileTransactionBusiness>()
                .InstancePerRequest();
        }
    }
}

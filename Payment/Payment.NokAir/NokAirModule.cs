using Autofac;
using AutoMapper;
using Payment.DAL;
using Payment.DAL.DbContexts.NokAir;
using Payment.DAL.DbContexts.NokAir.Entities;
using Payment.DAL.Interfaces;
using Payment.NokAir.Dtos;
using Payment.NokAir.Imps;
using Payment.NokAir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.NokAir
{
    public class NokAirMappingProfile : Profile
    {
        public NokAirMappingProfile()
        {
            CreateMap<NokTransaction, TransactionDto>().ReverseMap();
        }
    }

    public class NokAirIoCModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new DataModule());

            builder.RegisterType<NokTransactionBusiness>()
                .As<INokTransactionBusiness>()
                .InstancePerRequest();
        }
    }
}

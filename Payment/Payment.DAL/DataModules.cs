using Autofac;
using Payment.DAL.DbContexts.NokAir;
using Payment.DAL.DbContexts.ThaiSmile;
using Payment.DAL.DbContexts.VietJet;
using Payment.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.DAL
{
    public class DataModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<AirlineCoordinator>()
                .As<IAirlineCoordinator>()
                .InstancePerLifetimeScope();

            #region DbContext Registeration
            builder.RegisterType<NokAirContext>()
               .As<IDbContext>()
               .InstancePerRequest();


            builder.RegisterType<TSContext>()
                .As<IDbContext>()
                .InstancePerRequest();


            //builder.RegisterType<VJContext>()
            //   .As<IDbContext>()
            //   .InstancePerRequest();
            #endregion


            builder.RegisterType<DbContextStrategy>()
              .As<IDbContextStrategy>()
              .InstancePerLifetimeScope();


            builder.RegisterType<UnitOfWork.UnitOfWork>()
                .As<IUnitOfWork>()
                .InstancePerRequest();
        }
    }
}

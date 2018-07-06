using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using Payment.NokAir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Payment.NokController
{
    public class NokModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Dont forget this one, missing assembly 
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterModule(new NokAirIoCModule());
        }
    }

    public static class MappingProfile
    {
        public static Profile GetProfile()
        {
            return new NokAirMappingProfile();
        }
    }
}

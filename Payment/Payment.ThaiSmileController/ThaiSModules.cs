using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using Payment.ThaiSmile;
using Payment.ThaiSmile.Imps;
using Payment.ThaiSmile.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.ThaiSmileController
{
    public class ThaiSModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Dont forget this one, missing assembly 
            builder.RegisterApiControllers(System.Reflection.Assembly.GetExecutingAssembly());
            builder.RegisterModule(new ThaiSmileIoCModule());
        }
    }

    public static class MappingModule
    {
        public static Profile GetProfile()
        {
            return new ThaiSmileMappingProfile();
        }
    }
}

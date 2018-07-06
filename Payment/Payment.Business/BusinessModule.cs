using AutoMapper;
using Payment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Business
{
    public static class BusinessModule
    {
        public static void Init(string connectionString)
        {
            //Ioc Register


            DataModule.Init(connectionString);
        }
    }

    public class BusinessMappingProfile: Profile
    {
        public BusinessMappingProfile()
        {
            
        }
    }
}

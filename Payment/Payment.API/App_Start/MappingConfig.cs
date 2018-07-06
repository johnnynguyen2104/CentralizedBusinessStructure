using AutoMapper;

namespace Payment.API.App_Start
{
    public static class MappingConfig
    {
        public static MapperConfiguration InitMapping()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {

                cfg.AddProfile(Payment.NokController.MappingProfile.GetProfile());
                cfg.AddProfile(Payment.ThaiSmileController.MappingModule.GetProfile());
            });

            return config;
        }
    }
}
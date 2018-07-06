using Payment.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.DAL.DbContexts.NokAir.Entities
{
    public class NokAirUser : User
    {
        public DateTime? UpdatedDate { get; set; }
    }
}

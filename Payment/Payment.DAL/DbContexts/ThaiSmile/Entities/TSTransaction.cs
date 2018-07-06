using Payment.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.DAL.DbContexts.ThaiSmile.Entities
{
    public class TSTransaction : Transaction
    {
        public Nullable<double> InsurranceAmount { get; set; }
    }
}

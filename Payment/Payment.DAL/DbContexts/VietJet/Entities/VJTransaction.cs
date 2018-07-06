using Payment.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.DAL.DbContexts.VietJet.Entities
{
    public class VJTransaction : Transaction
    {
        public int NumberOfPass { get; set; }
    }
}

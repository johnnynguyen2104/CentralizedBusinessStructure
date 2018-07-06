using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.DAL.BaseEntities
{
    public abstract class Transaction
    {
        public int Id { get; set; }

        public double Amount  { get; set; }

        public string DepartureLocation { get; set; }

        public string Destination { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Now;
    }
}

using Payment.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.ThaiSmile.Dtos
{
    public class TransactionDto : BaseTransactionDTO
    {
        public Nullable<double> InsurranceAmount { get; set; }
    }
}

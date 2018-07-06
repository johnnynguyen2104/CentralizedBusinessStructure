using Payment.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Core.Interfaces
{
    public interface ITransactionBusiness
    {
        bool Create<TInputType>(TInputType user);

        IList<TReturn> GetData<TReturn>();
    }
}

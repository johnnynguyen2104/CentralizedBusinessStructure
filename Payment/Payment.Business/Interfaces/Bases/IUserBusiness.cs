using Payment.Business.Dtos.Bases;
using Payment.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Business.Interfaces.Bases
{
    public interface IUserBusiness<TEntity> where TEntity : class
    {
        bool Create(TEntity user);

        IList<TEntity> GetData();
    }
}

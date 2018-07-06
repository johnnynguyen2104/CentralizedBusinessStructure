using Payment.Business.Interfaces.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payment.Business.Dtos.Bases;
using Payment.DAL.Interfaces;

namespace Payment.Business.Imps.Bases
{
    public class UserBusiness : IUserBusiness<UserDto>
    {
        
        public UserBusiness()
        {

        }

        public virtual bool Create(UserDto user)
        {
            throw new NotImplementedException();
        }

        public IList<UserDto> GetData()
        {
            throw new NotImplementedException();
        }
    }
}

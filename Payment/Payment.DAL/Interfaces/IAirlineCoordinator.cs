using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Payment.DAL.Interfaces
{
    public interface IAirlineCoordinator
    {
        HttpRequest Request { get; set; }

        Dictionary<string, int> Airlines { get; set; }


        int GetAirlineId();
    }
}

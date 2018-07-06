using Payment.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Payment.DAL
{
    public class AirlineCoordinator : IAirlineCoordinator
    {
        public Dictionary<string, int> Airlines { get; set; }

        public AirlineCoordinator()
        {
            Request = HttpContext.Current.Request;

            Airlines = new Dictionary<string, int>();
            Airlines.Add("localhost:51659", 0);
            Airlines.Add("localhost:51646", 1);
            //Airlines.Add("localhost:51306", 2);
        }

        public HttpRequest Request { get; set; }

        public int GetAirlineId()
        {
            if (Airlines != null)
            {
                string url = Request.UrlReferrer.Authority;

                if (!Airlines.ContainsKey(url))
                {
                    return -1;
                }
                return Airlines[url];
            }
            else
            {
                Airlines = new Dictionary<string, int>();

                return -1;
            }
        }
    }
}

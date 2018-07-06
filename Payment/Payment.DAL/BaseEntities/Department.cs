using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.DAL.BaseEntities
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

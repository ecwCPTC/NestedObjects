using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    public class Advisor
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string OfficeLocation { get; set; }

        public Advisor AssignedAdvisor { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Application.Dtos.security
{
    public class UserSecurityQuickFilter
    {
        public string Resident { get; set; }
        public bool Active { get; set; }
        public string Gender { get; set; }
    }
}

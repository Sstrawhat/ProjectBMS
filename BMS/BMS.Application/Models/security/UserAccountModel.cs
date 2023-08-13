using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Application.Models.security
{
    public class UserAccountModel
    {
        [Key]
        public int UserAccountId { get; set; }

        public string? Firstname { get; set; }
                     
        public string? Lastname { get; set; }
                     
        public string? EmailAddress { get; set; }
                     
        public string? Username { get; set; }
                     
        public string? Password { get; set; }

        public short? Usertype { get; set; }

        public bool? AdminAccess { get; set; }

        public bool? BarangayAccess { get; set; }

        public bool? IsActivated { get; set; }


    }
}

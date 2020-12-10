using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Building_Manage.Models
{
    public class ValidAdminModel
    {
        public string PhoneNumber { get; set; }
        public string OtpCode { get; set; }
        public string Type { get; set; }
        public string Cksum { get; set; }
        public string DKey { get; set; }
    }
}

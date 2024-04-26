using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Core.Entity
{
    public class Contact
    {


        public required string Email { get; set; }

        public string? PhoneNumber { get; set; }
    }
}

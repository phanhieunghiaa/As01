using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessObject
{
    public class MemberObject
    {
        public int MemID { get; set; }
        public string MemName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

    }
}

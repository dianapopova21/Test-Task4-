using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests.Models
{
    public class AppUser: IdentityUser
    {
        public string NickName { get; set; }
    }
}

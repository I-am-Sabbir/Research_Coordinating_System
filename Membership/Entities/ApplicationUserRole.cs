using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Microsoft.AspNetCore.Identity;

namespace Membership.Entities
{
    public class ApplicationUserRole
     : IdentityUserRole<Guid>
    {
        public ApplicationUser User { get; set; }
        public Role Role { get; set; }
    }
}

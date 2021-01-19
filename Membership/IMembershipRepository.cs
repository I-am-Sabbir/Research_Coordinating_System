using Data;
using Membership.Contexts;
using Membership.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Membership
{
    public interface IMembershipRepository : IRepository<ApplicationUser, Guid, ApplicationDbContext>
    {
        
    }
}

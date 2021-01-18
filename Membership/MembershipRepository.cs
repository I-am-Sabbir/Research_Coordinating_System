using Data;
using Membership.Contexts;
using Membership.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Membership
{
    public class MembershipRepository : Repository<ApplicationUser, Guid, ApplicationDbContext>, IMembershipRepository
    {
        public MembershipRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        //public Task<(IEnumerable<ApplicationUser> data, int total, int totalFiltered)> GetAllUsersAsync(int pageIndex, int pageSize, string searchText, string sortText)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

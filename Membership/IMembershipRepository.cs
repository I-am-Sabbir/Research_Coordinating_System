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
        //Task<ApplicationUser> GetMemberInfoAsync(string email);
        //Task UpdateMemberInfoAsync(ApplicationUser memberData, Guid memberId);
        //Task<(IEnumerable<ApplicationUser> data, int total, int totalFiltered)> GetAllUsersAsync(int pageIndex, int pageSize, string searchText, string sortText);

    }
}

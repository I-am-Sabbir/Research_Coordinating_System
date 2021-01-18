using Data;
using Membership.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Membership
{
    public class MembershipUnitOfWork : UnitOfWork, IMembershipUnitOfWork
    {
        public IMembershipRepository MembershipRepository { get; set; }
        public MembershipUnitOfWork(ApplicationDbContext dbContext, IMembershipRepository membershipRepository) : base(dbContext)
        {
            MembershipRepository = membershipRepository;
        }
    }
}

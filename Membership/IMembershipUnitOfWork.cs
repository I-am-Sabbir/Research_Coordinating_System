using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Membership
{
    public interface IMembershipUnitOfWork : IUnitOfWork
    {
        IMembershipRepository MembershipRepository { get; set; }
    }
}

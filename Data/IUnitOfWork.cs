using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}

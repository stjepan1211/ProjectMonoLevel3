﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Common
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Complete();
        void Dispose(bool disposing);
        void Dispose();
    }
}

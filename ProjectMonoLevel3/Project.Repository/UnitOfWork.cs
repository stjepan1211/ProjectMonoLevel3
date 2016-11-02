using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL.Common;
using Project.Repository.Common;
using Project.Repository.Repositories;

namespace Project.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IVehicleContext context;
        private bool disposed;

        public UnitOfWork(IVehicleContext context)
        {
            this.context = context;
        }

        public async Task<int> Complete()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }
    }
}

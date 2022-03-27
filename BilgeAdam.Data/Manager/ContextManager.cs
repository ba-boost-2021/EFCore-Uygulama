using BilgeAdam.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.Manager
{
    public static class ContextManager
    {
        private static NorthwindDbContext context;
        private static object @lock = new object();

        public static NorthwindDbContext GetDbContext()
        {
            if (context is not null)
            {
                return context;
            }
            lock (@lock)
            {
                if (context is not null)
                {
                    return context;
                }
                context = new NorthwindDbContext();
            }
            return context;
        }
    }
}

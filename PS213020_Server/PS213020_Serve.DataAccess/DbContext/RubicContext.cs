using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PS213020_Serve.DataAccess.Core.Interface.Context;
using PS213020_Serve.DataAccess.Core.Models;

namespace PS213020_Serve.DataAccess.DbContext
{
    class RubicContext : Microsoft.EntityFrameworkCore.DbContext, IRubicContext
    {
        public RubicContext(DbContextOptions<RubicContext> options)
            : base(options)
        {

        }
        public DbSet<UserRto> Users { get; set; }
        public DbSet<UserRoleRto> UserRoles { get; set; }

    }
}

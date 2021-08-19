using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AT_CRUD.Models;

namespace AT_CRUD.Data
{
    public class AT_CRUDContext : DbContext
    {
        public AT_CRUDContext (DbContextOptions<AT_CRUDContext> options)
            : base(options)
        {
        }

        public DbSet<AT_CRUD.Models.Amigo> Amigo { get; set; }
    }
}

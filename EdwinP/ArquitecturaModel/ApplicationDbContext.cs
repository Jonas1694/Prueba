using ArquitecturaModel.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquitecturaModel
{
    public class ApplicationDbContext: IdentityDbContext<IdentityUser>
    {
        public DbSet<Productos> Producto { get; set;}
        public DbSet<Proveedores> Proveedores { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

}

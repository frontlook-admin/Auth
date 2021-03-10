using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Hosting;

namespace Auth.Data
{
    public sealed class AuthContext : IdentityDbContext
    {
        public AuthContext(DbContextOptions<AuthContext> options, IWebHostEnvironment env) : base(options)
        {
            if (!env.IsDevelopment())
            {
                if (Database.GetPendingMigrations().Any())
                {
                    Database.Migrate();
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            
           


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WelchDentistry.Models;
using WelchDentistry.Areas.Identity.Data;

namespace WelchDentistry.Data
{
    public class ApplicationDbContext : IdentityDbContext<WelchDentistryUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WelchDentistry.Models.Appointment> Appointment { get; set; }
    }
}

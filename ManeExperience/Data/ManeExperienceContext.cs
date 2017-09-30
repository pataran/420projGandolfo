using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ManeExperience.Models
{
    public class ManeExperienceContext : DbContext
    {
        public ManeExperienceContext (DbContextOptions<ManeExperienceContext> options)
            : base(options)
        {
        }

        public DbSet<ManeExperience.Models.Events> Events { get; set; }
    }
}

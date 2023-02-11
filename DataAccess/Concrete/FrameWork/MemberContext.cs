using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.FrameWork
{
    public class MemberContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = BURAK; Database=dbMember;Trusted_Connection=true");
        }

        public DbSet<Member> Members  { get; set; }
        public DbSet<Instructor> Instructors  { get; set; }
        public DbSet<InstructorImage> ınstructorImages  { get; set; }
        



    }
}

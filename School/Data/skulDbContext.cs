using Microsoft.EntityFrameworkCore;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace School.Data
{
    public class skulDbContext:DbContext
    {
        public skulDbContext(DbContextOptions<skulDbContext> options):base(options)
        {

        }

        //table present on mssql server
        public DbSet<Section> Sections { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<School.Models.ViewModels.StudentViewModel> StudentViewModel { get; set; }
        public DbSet<School.Models.ViewModels.CreateStudentViewModel> CreateStudentViewModel { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<SelectListItem>();
            modelBuilder.Ignore<SelectListGroup>();
        }



    }
}

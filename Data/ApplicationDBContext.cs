﻿using FarmApplication.Model;
//using FarmApplication.Pages.Maps;
using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;


// this DBContext was used for creating the field datatype, it was meant as a test table, hence the poorly named file

namespace FarmApplication.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        { 
        
        }
        public DbSet<Field> Fields { get; set; }
		public DbSet<FarmResources> Resources { get; set; }
		public DbSet<Equipment> Equipment { get; set; }
		public DbSet<Workers> Workers { get; set; }
        public DbSet<FarmTasks> Tasks { get; set; }
        //public DbSet<Map> Maps { get; set; }
	}
}

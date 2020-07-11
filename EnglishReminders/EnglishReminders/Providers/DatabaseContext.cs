using EnglishReminders.Entites;
using EnglishReminders.Managers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EnglishReminders.Providers
{
    //Veri Tabanı Bağlantıları
    public class DatabaseContext : DbContext
    {
  
        public DbSet<Words> DbWords { get; set; }
        public DbSet<UserWords> DbuserWords { get; set; }
        public DbSet<User> DbUsers { get; set; }
        public DbSet<Score> DbScores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MEHMET-KOYUNCı-;Initial Catalog=EnglishRemindersDB;Integrated Security=SSPI;");
        }


    }
}

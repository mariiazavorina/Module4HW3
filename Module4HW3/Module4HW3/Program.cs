﻿using System;
using Module4HW3.DataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Module4HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var connectionString = configuration.GetConnectionString("Module4HW3");
            dbOptionsBuilder.UseSqlServer(connectionString, i => i.CommandTimeout(20));

            var applicationContext = new ApplicationContext(dbOptionsBuilder.Options);
            applicationContext.SaveChanges();
        }
    }
}

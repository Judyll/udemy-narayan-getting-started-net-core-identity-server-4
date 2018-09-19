﻿using Microsoft.EntityFrameworkCore;

namespace BankOfDotNet.API.Models
{
    /// <summary>
    /// This is the DB Context
    /// </summary>
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options)
            : base(options) { }

        // The set of customers in our in-memory database
        public DbSet<Customer> Customers { get; set; }
    }
}

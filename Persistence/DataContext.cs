﻿using Domain;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace Persistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Activity> Activities { get; set; }
}
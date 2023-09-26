﻿using Microsoft.EntityFrameworkCore;
using ShopCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class ShopContext: DbContext
    {
        public ShopContext
            (
                DbContextOptions<ShopContext> options
            ):base(options) { }
        public DbSet<Spaceship> Spaceships { get; set; }
        public DbSet<FileToApi> FileToApis { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<FileTiApi> FileTiApis { get; set; }
    }

    
}

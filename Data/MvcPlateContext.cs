﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcPlate.Models;

namespace MvcPlate.Data
{
    public class MvcPlateContext : DbContext
    {
        public MvcPlateContext(DbContextOptions<MvcPlateContext> options)
            : base(options)
        {
        }

        public DbSet<Plate> Plate { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityModels
{
    public class DiplomaContext : DbContext
    {
        public DiplomaContext()
            : base("name=DefaultConnection")
        {

        }

        public DbSet<Term> Terms { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Choice> Choices { get; set; }
    }
}
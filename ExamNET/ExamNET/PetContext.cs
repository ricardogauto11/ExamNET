using ExamNET.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamNET
{
    public class PetContext: DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}
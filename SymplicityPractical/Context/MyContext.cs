using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using SymplicityPractical.Entities;

namespace SymplicityPractical.Context
{
    public class MyContext : DbContext
    {
        public virtual DbSet<ImageVote> ImageVotes { get; set; }
    }
}
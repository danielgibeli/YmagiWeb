using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YmagiWebMvc.Models;

namespace YmagiWebMvc.Data
{
    public class YmagiWebMvcContext : DbContext
    {
        public YmagiWebMvcContext (DbContextOptions<YmagiWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<YmagiWebMvc.Models.Osc> Osc { get; set; }
    }
}

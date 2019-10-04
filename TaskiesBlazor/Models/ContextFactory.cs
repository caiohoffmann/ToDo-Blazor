using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskiesBlazor.Models
{
    public class ContextFactory
    {
        public static Context GetContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlServer(Helpers.Keys.ConnectionString);
            return new Context(optionsBuilder.Options);
        }
    }
}

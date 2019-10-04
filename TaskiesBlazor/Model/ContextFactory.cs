using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskiesBlazor.Model
{
    public class ContextFactory
    {
        public static Context GetContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlServer("Server=tcp:ses22h08rw.database.windows.net,1433;Initial Catalog=ToDo;Persist Security Info=False;User ID=FestaDuroDB;Password=Hugo$#Caio;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            return new Context(optionsBuilder.Options);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeBasedEntity
{
    [DbConfigurationType(typeof(Configuracao))]
    public class DbContexto : DbContext
    {
        public DbSet<Pessoa> pessoas { get; set; }
        public DbContexto(String strConnection) :base(strConnection)
        {
            //"Data Source=localhost;Persist Security Info=True;User ID=sa;Password=just@me2014"
        }
    }
}

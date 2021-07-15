using Classes.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Infra.EF
{
    public class VeiculoContext : DbContext
    {
        public VeiculoContext(DbContextOptions<VeiculoContext> options) 
            : base(options) 
        {   
        }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}

using Classes.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Infra.EF
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly VeiculoContext dbContext;

        public VeiculoRepository(VeiculoContext dbContext) => this.dbContext = dbContext;

        public void Add(Veiculo veiculo)
        {
            dbContext.Veiculos.Add(veiculo);
            dbContext.SaveChanges();
        }

        public void Delete(Veiculo veiculo)
        {
            dbContext.Veiculos.Remove(veiculo);
            dbContext.SaveChanges();
        }

        public IEnumerable<Veiculo> GetAll() => dbContext.Veiculos.ToListAsync().Result;

        public Veiculo GetByID(Guid id) => dbContext.Veiculos.SingleOrDefaultAsync(c => c.Id == id).Result;

        public void Update(Veiculo veiculo)
        {
            dbContext.Entry(veiculo).State = EntityState.Modified;
            //dbContext.Veiculos.Update(veiculo);
            dbContext.SaveChanges();
            }
        }
}

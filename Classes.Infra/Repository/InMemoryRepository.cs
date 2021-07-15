using Classes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.Infra.Repository
{
    public class InMemoryRepository : IVeiculoRepository
    {
        private readonly List<Veiculo> veiculos = new List<Veiculo>();

        public void Add(Veiculo veiculo) => veiculos.Add(veiculo);


        public void Delete(Veiculo veiculo) => veiculos.Remove(veiculo);

        public IEnumerable<Veiculo> GetAll()
        {
            return veiculos.ToList();
        }

        public Veiculo GetByID(Guid id) => veiculos.SingleOrDefault(c => c.Id == id);

        public void Update(Veiculo veiculo)
        {
            veiculos.Remove(GetByID(veiculo.Id));
            veiculos.Add(veiculo);
        }
    }
}

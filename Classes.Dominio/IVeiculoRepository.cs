using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Dominio
{
    public interface IVeiculoRepository
    {
        Veiculo GetByID(Guid id);

        IEnumerable<Veiculo> GetAll();

        void Add(Veiculo veiculo);

        void Delete(Veiculo veiculo);

        void Update(Veiculo veiculo);
    }
}

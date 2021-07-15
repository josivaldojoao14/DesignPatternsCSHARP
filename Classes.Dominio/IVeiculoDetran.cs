using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Dominio
{
    public interface IVeiculoDetran
    {
        public Task AgendarVistoria(Guid veiculoId);

    }
}

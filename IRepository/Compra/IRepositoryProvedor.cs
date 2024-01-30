using DBZapateriaDLopezModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.Compra
{
    public interface IRepositoryProvedor : IRepositoryCrud<Provedor>
    {
        Provedor BuscarId(int idPersona);
    }
}

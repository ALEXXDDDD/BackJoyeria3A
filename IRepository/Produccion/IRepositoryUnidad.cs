using DBZapateriaDLopezModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.Produccion
{
    public interface IRepositoryUnidad:IRepositoryCrud<Unidad>
    {
        public Unidad BuscarNombre(string nombre);
        public List<Unidad> BuscaMultipleUnidad(List<string> nombre);
    }
}

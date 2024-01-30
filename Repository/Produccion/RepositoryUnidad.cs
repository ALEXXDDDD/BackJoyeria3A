using DBZapateriaDLopezModel;
using IRepository.Produccion;
using RequestResponseModel.Request;
using RequestResponseModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Produccion
{
    public class RepositoryUnidad : RepositoryCrud<Unidad>, IRepositoryUnidad
    {
        public List<Unidad> BuscaMultipleUnidad(List<string> nombre)
        {
            throw new NotImplementedException();
        }

        public Unidad BuscarNombre(string nombreUnidad)
        {
            Unidad? unidad = db.Unidads.
                Where(x => x.NombreUnidad == nombreUnidad).FirstOrDefault();
            return unidad;
        }

        public ResponseFilterGeneric<Unidad> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}

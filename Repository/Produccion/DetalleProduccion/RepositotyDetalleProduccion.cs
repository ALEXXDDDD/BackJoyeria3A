using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBZapateriaDLopezModel;
using IRepository.Produccion.DetalleProduccion;
using RequestResponseModel.Request;
using RequestResponseModel.Response;

namespace Repository.Produccion.DetalleProduccion
{
    public class RepositotyDetalleProduccion : RepositoryCrud<VwDetalleProduccion>, IRepositoryDetalleProduccion
    {
        public ResponseFilterGeneric<VwDetalleProduccion> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBZapateriaDLopezModel;
using IRepository.Produccion.Modelos;
using RequestResponseModel.Request;
using RequestResponseModel.Response;

namespace Repository.Produccion.Modelos
{
    public class RepositoryModelo : RepositoryCrud<Modelo>, IReqpositoryModelo
    {
        public ResponseFilterGeneric<Modelo> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}

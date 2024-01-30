using DBZapateriaDLopezModel;
using IRepository.Produccion.TB_Area;
using RequestResponseModel.Request;
using RequestResponseModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Produccion.TB_Area
{
    public class RepositoryArea : RepositoryCrud<Area>, IRepositoryArea
    {
        public ResponseFilterGeneric<Area> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}

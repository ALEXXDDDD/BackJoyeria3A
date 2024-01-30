using DBZapateriaDLopezModel;
using IRepository.Compra;
using RequestResponseModel.Request;
using RequestResponseModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Compra
{
    public class RepositoryProvedor : RepositoryCrud<Provedor>, IRepositoryProvedor
    {
        public Provedor BuscarId(int idPersona)
        {
            Provedor? provedor = dbSet.
                Where(x => x.IdPersona == idPersona).FirstOrDefault();
            return provedor;
        }

        public ResponseFilterGeneric<Provedor> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}

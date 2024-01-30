using DBZapateriaDLopezModel;
using IRepository.Sistema;
using RequestResponseModel.Request;
using RequestResponseModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Sistema
{
    public class RepositoryVWUsuario : RepositoryCrud<VwUsuario>,IRepositorVWUsuario
    {
        public ResponseFilterGeneric<VwUsuario> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public VwUsuario OptenerUsuario(string userName)
        {
            VwUsuario? usuario = db.VwUsuarios.
                Where(x => x.Usuario == userName).FirstOrDefault();
            return usuario;
        }
    }
}

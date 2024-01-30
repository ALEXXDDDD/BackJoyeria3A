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
    public class RepositoryPersona : RepositoryCrud<Persona>, IRepositoryPersona
    {
        public Persona BuscarId(string nombrePersona)
        {
            Persona? persona = db.Personas.
                Where(x => x.NombrePersona == nombrePersona).FirstOrDefault();
            return persona;
        }

        public ResponseFilterGeneric<Persona> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}

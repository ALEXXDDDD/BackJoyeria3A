using DBZapateriaDLopezModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.Sistema
{
    public interface IRepositorVWUsuario:IRepositoryCrud<VwUsuario>
    {
        public VwUsuario OptenerUsuario(string usurName);
    }
}

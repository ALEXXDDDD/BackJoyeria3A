using DBZapateriaDLopezModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.Compra.TB_Material
{
    public interface IRepositoryMaterial : IRepositoryCrud<Material>
    {
        public Material BuscarMaterial(string nameMaterial);
    }
}

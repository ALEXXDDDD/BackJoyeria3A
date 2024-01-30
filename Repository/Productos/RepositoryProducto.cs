using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBZapateriaDLopezModel;
using IRepository.Productos;
using RequestResponseModel.Request;
using RequestResponseModel.Response;

namespace Repository.Productos
{
    public class RepositoryProducto : RepositoryCrud<Producto>, IRepositoryProducto
    {
        public ResponseFilterGeneric<Producto> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
        public Producto ObtenerProducto (string nombreProducto)
        {
            Producto? producto = db.Productos.Where(x => x.NombreProd == nombreProducto).FirstOrDefault();
            return producto;
        }
    }
}

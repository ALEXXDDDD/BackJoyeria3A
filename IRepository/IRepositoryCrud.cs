using RequestResponseModel.Response;
using RequestResponseModel.Request;
namespace IRepository
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Nombre de Clase a Utilizar</typeparam>
    public interface IRepositoryCrud<T>:IDisposable
    {
        List<T> GetAll();
        T GetById(object id);
        T Create(T entity);
        List<T> CreateMultiple(List<T> lista);
        T Update(T entity);
        List<T> UpdateMultiple(List<T> lista);
        int Delete(object id);
        int DeleteMultiple(List<T> lista);

        ResponseFilterGeneric<T> GetByFilter(RequestFilterGeneric request);
    }
}
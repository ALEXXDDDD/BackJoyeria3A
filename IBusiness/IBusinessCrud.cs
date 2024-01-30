namespace IBusiness
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Request</typeparam>
    /// <typeparam name="Y">Response</typeparam>
    public interface IBusinessCrud<T,Y>:IDisposable
    {
        List<Y> GetAll();
        Y GetById(object id);
        Y Create(T entity);
        List<Y> CreateMultiple(List<T> lista);
        Y Update(T entity);
        List<Y> UpdateMultiple(List<T> lista);
        int Delete(object id);
        int DeleteMultiple(List<T> lista);
    }
}
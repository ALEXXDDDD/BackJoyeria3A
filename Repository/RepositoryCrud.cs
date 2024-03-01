using Azure.Core;
using DBZapateriaDLopezModel;
using IRepository;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity">Nombre de la Tabla</typeparam>
    public class RepositoryCrud<TEntity> where TEntity: class
    {
        #region Inyeccion de dependencias
        internal _dbTramiteDocumentarioContext db;
        internal DbSet<TEntity> dbSet;
        public RepositoryCrud()
        {
            db = new();
            dbSet = db.Set<TEntity>();
        }
        #endregion Inyeccion de dependencias
        #region Crud
        public TEntity Create(TEntity entity)
        {
            dbSet.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public List<TEntity> CreateMultiple(List<TEntity> lista)
        {
            dbSet.AddRange(lista);
            db.SaveChanges();
            return lista;
        }

        public int Delete(object id)
        {
            TEntity? entity = dbSet.Find(id);
            dbSet.Remove(entity);
            return db.SaveChanges();
        }

        public int DeleteMultiple(List<TEntity> lista)
        {
            TEntity? entity = dbSet.Find(lista);
            dbSet.RemoveRange(entity);
            return db.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<TEntity> GetAll()
        {
            IQueryable<TEntity> query = dbSet;
            return query.ToList();
        }

        public TEntity GetById(object id)
        {
            return dbSet.Find(id);
        }

        public TEntity Update(TEntity entity)
        {
            dbSet.Update(entity);
            db.SaveChanges();
            return entity;
        }

        public List<TEntity> UpdateMultiple(List<TEntity> lista)
        {
            dbSet.UpdateRange(lista);
            db.SaveChanges();
            return lista;
        }
        #endregion Crud
    }
}
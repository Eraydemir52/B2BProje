using B2BProje.Core.DataAccess.Entityframework;
using B2BProje.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace B2BProje.Core.DataAccess.Entityframework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        protected readonly TContext _context;


        public EfEntityRepositoryBase(TContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteID(int id)
        {
            var entityToDelete = _context.Set<TEntity>().Find(id);
            if (entityToDelete != null)
            {
                _context.Set<TEntity>().Remove(entityToDelete);
                _context.SaveChanges();
            }
        }






        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                // Örnek olarak, Entity Framework kullanılıyorsa:
                return _context.Set<TEntity>().FirstOrDefault(filter);

                // veya Dapper kullanılıyorsa:
                // return _connection.QueryFirstOrDefault<TEntity>("SELECT * FROM YourTable WHERE YourCondition", parameters);
            }
            catch (Exception ex)
            {
                // Hata durumunu loglama veya uygun bir şekilde işleme ekleme
                Console.WriteLine($"Get method error: {ex.Message}");
                throw; // Hatanın tekrar fırlatılması
            }
        }


        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _context.Set<TEntity>().ToList()
                : _context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }

    }
}

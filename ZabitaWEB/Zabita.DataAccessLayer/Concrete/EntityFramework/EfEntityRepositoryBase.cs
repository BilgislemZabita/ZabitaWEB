using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Zabita.DataAccessLayer.Abstract;
using Zabita.Entities.Abstract;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var eklenenEntity = context.Entry(entity);
                eklenenEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var silinenEntity = context.Entry(entity);
                silinenEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                using (TContext context = new TContext())
                {
                    var guncelEntity = context.Entry(entity);
                    guncelEntity.State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Tablodan bir satır seçiniz!!" +
                    "\n" + "\n", " Veritabanı Güncelleme Hatası");
            }
        }
    }
}
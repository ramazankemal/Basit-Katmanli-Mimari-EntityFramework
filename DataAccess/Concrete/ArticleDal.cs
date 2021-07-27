using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class ArticleDal : IArticleDal
    {
        public void Add(Article entity)
        {
            using(SqlServerContext context=new SqlServerContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Article entity)
        {
           using(SqlServerContext context=new SqlServerContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Article Get(Expression<Func<Article, bool>> filter)
        {
            using(SqlServerContext context=new SqlServerContext())
            {
                return context.Set<Article>().SingleOrDefault(filter);
            }
        }

        public List<Article> GetAll(Expression<Func<Article, bool>> filter = null)
        {
            using(SqlServerContext context=new SqlServerContext())
            {
                return filter == null
                    ? context.Set<Article>().ToList()
                    : context.Set<Article>().Where(filter).ToList();
            }
        }

        public void Update(Article entiy)
        {
            using(SqlServerContext context=new SqlServerContext())
            {
                var updatedEntity = context.Entry(entiy);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

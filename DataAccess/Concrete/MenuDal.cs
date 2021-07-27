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
    public class MenuDal : IMenuDal
    {


        public void Add(Menu entity)
        {
            using(SqlServerContext context=new SqlServerContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Menu entity)
        {
            using(SqlServerContext context=new SqlServerContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Menu Get(Expression<Func<Menu, bool>> filter)
        {
           using(SqlServerContext context=new SqlServerContext())
            {
                return context.Set<Menu>().SingleOrDefault(filter);
            }
        }

        public List<Menu> GetAll(Expression<Func<Menu, bool>> filter = null)
        {
            using(SqlServerContext context=new SqlServerContext())
            {
                return filter == null
                    ? context.Set<Menu>().ToList()
                    : context.Set<Menu>().Where(filter).ToList();
            }
        }

        public void Update(Menu entiy)
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

using DataAccess.Context;
using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly RestaurantContext restaurantContext;
        private DbSet<T> entities;

        public BaseRepository(RestaurantContext _restaurantContext)
        {
            restaurantContext = _restaurantContext;
            entities = restaurantContext.Set<T>();
        }
        public string Create(T entity)
        {
            try
            {
                entities.Add(entity);
                restaurantContext.SaveChanges();
                return $"Veri Başarıyla Eklendi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Delete(T entity)
        {
            try
            {
                entities.Remove(entity);
                restaurantContext.SaveChanges();
                return $"Veri Başarıyla Silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<T> GetAll()
        {
            return entities.ToList();
        }

        public T GetById(int id)
        {
            return entities.Find(id);
        }

        public string Update(T entity)
        {
            try
            {
                entities.Update(entity);
                restaurantContext.SaveChanges();
                return $"Veri Başarıyla Güncelledi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return restaurantContext.Set<T>().Where(exp).ToList();
        }
    }
}

using BlazorCRUDEntityFramwork.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDEntityFramwork.Data
{
    public class DishService : IDishService
    {
        private readonly DataContext _dataContext;

        public DishService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> DeleteDish(int id)
        {
            var dish = await _dataContext.Dish.FindAsync(id);
            _dataContext.Remove(dish);
            return await _dataContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Dish>> GetAllDish()
        {
            return await _dataContext.Dish.ToListAsync();
        }

        public async Task<Dish> GetDishDetails(int id)
        {
            return await _dataContext.Dish.FindAsync(id);
        }

        public async Task<bool> InsertDish(Dish dish)
        {
            _dataContext.Dish.Add(dish);
            return await _dataContext.SaveChangesAsync() > 0;
        }
        public async Task<bool> UpdateDish(Dish dish)
        {
            _dataContext.Entry(dish).State = EntityState.Modified;
            return await _dataContext.SaveChangesAsync() > 0;
        }
        public async Task<bool> SaveDish(Dish dish)
        {
            if (dish.DishId > 0)
            {
                return await UpdateDish(dish);
            }
            else
            {
                return await InsertDish(dish);
            }
        }


    }
}

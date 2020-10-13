using BlazorCRUDEntityFramwork.Models;
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
            throw new NotImplementedException();
        }

        public async Task<Dish> GetDishDetails(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertDish(Dish dish)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateDish(Dish dish)
        {
            throw new NotImplementedException();
        }
    }
}

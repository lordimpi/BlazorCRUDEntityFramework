using BlazorCRUDEntityFramwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDEntityFramwork.Data
{
    public interface IDishService
    {
        Task<IEnumerable<Dish>> GetAllDish();
        Task<Dish> GetDishDetails(int id);
        Task<bool> InsertDish(Dish dish);
        Task<bool> UpdateDish(Dish dish);
        Task<bool> DeleteDish(int id);
        Task<bool> SaveDish(Dish dish);
    }
}

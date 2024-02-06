using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data
{
    public class PizzaService
    {
        private readonly PizzaStoreContext _dbContext;

        public PizzaService(PizzaStoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        // public async Task<Pizza[]> GetPizzasAsync()
        // {
        //     // Retrieve pizzas from the database asynchronously
        //     return await _dbContext.Pizzas.ToArrayAsync();
        // }

        // public async Task<List<Pizza>> GetPizzasAsync()
        // {
        //     // Retrieve pizzas from the database asynchronously
        //     return await _dbContext.Pizzas.ToListAsync();
        // }
    }
}

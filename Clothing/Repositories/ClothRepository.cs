using Clothing.Entities;
using Clothing.Models;
using System.Collections.Generic;
using System.Linq;

namespace Clothing.Repositories
{
    public class ClothRepository
    {
        ClothContext clothContext;

        public ClothRepository(ClothContext clothContext)
        {
            this.clothContext = clothContext;
        }

        public List<Clothes> ListOfClothes()
        {
            return clothContext.warehouse.ToList();
        }
    }
}

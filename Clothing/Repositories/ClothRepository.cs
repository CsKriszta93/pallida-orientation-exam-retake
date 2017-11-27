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

        public Clothes GetSelectedItem(string item)
        {
            var cloth = (from clothes in clothContext.warehouse
                         where clothes.item_name == item
                         select clothes).FirstOrDefault();
            return cloth;
        }
    }
}

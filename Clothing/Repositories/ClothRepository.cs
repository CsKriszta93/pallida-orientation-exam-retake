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

        public void AddClothes(string item, int amount, string size)
        {
            while (amount > 0)
            {
                clothContext.warehouse.Add(new Clothes {item_name = item, size = size);
            }
            clothContext.SaveChanges();
        }

        public List<Clothes> GetClothesPrices()
        {
            var list = ListOfClothes();
            var price = (from clothes in list
                         where clothes.unit_price > 50
                         select clothes).ToList();
            return price;
        }
    }
}

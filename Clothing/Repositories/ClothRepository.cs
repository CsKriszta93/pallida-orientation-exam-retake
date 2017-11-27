using Clothing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clothing.Repositories
{
    public class ClothRepository
    {
        ClothContext clothContext;

        public ClothRepository(ClothContext clothContext)
        {
            this.clothContext = clothContext;
        }
    }
}

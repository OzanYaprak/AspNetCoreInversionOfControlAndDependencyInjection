﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionImplementation
{
    public class DataAccessLayer : IDataAccessLayer
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product { Id = 1, Name= "Kalem", Price=100, Stock=50 },
                new Product { Id = 2, Name= "Kitap", Price=400, Stock=150 },
                new Product { Id = 3, Name= "Silgi", Price=200, Stock=250 },
                new Product { Id = 4, Name= "Defter", Price=600, Stock=550 },
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using TestProjectDevExpress.Models;
using TestProjectDevExpress.Repos;

namespace TestProjectDevExpress.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService() { }
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public IEnumerable<Product> ListAllProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    ProductId = 12,
                    ProductName = "Laptop",
                    Price = 1750,
                    StockCount = 100,
                    Category = "Electronic"
                },
                new Product()
                {
                    ProductId = 15,
                    ProductName = "Monitor",
                    Price = 720,
                    StockCount = 32,
                    Category = "Electronic"
                },
                new Product()
                {
                    ProductId = 17,
                    ProductName = "Mouse",
                    Price = 25,
                    StockCount = 100,
                    Category = "Electronic"
                },
                new Product()
                {
                    ProductId = 19,
                    ProductName = "Keyboard",
                    Price = 40,
                    StockCount = 100,
                    Category = "Electronic"
                },
                new Product()
                {
                    ProductId = 21,
                    ProductName = "Phone",
                    Price = 2800,
                    StockCount = 500,
                    Category = "Electronic"
                },
                new Product()
                {
                    ProductId = 23,
                    ProductName = "Printer",
                    Price = 500,
                    StockCount = 10,
                    Category = "Electronic"
                }
            };
        }
    }
}

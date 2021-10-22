using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectDevExpress.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int StockCount { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return this.ProductId.ToString() + "," + this.ProductName + "," + this.Price.ToString() + "," + this.StockCount.ToString() + "," + this.Category;
        }
    }
}

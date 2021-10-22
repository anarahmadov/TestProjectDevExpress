using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Text;
using TestProjectDevExpress.Models;

namespace TestProjectDevExpress.Services
{
    public interface IProductService
    {
        IEnumerable<Product> ListAllProducts();
    }
}

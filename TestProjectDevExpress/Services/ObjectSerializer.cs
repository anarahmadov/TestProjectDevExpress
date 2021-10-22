using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace TestProjectDevExpress.Services
{
    public class ObjectSerializer : IObjectSerializer
    {
        public string ConvertToCSV<T>(List<T> @object) where T : class, new()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("ProductId,ProductName,Price,StockCount,Category");

            foreach (var item in @object)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public string ConvertToTXT<T>(List<T> @object) where T : class, new()
        {
            return JsonConvert.SerializeObject(@object);
        }
    }
}

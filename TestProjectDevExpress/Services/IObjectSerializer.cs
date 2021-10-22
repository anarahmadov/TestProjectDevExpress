using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectDevExpress.Services
{
    public interface IObjectSerializer
    {
        string ConvertToCSV<T>(List<T> @object) where T : class, new();
        string ConvertToTXT<T>(List<T> @object) where T: class, new();
    }
}

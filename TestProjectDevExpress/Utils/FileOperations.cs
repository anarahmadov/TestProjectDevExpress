using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace TestProjectDevExpress.Utils
{
    public static class FileOperations
    {
        public static bool WriteContentToFile(string fileContent, string destination, string fileName)
        {
            try
            {
                using (FileStream fileStream = File.Create(destination + fileName))
                {
                    // Add some text to file    
                    Byte[] content = new UTF8Encoding(true).GetBytes(fileContent);
                    fileStream.Write(content, 0, content.Length);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi" + " " + ex.Message);
                return false;
            }
        }
    }
}

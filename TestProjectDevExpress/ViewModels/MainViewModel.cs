using DevExpress.Mvvm;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using TestProjectDevExpress.Models;
using TestProjectDevExpress.Services;
using TestProjectDevExpress.Utils;

namespace TestProjectDevExpress.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IProductService _productService;
        private readonly IObjectSerializer _objectSerializer;

        public MainViewModel(IProductService productService, IObjectSerializer objectSerializer)
        {
            _productService = productService;
            _objectSerializer = objectSerializer;
            ExportToCSVCommand = new DelegateCommand(ExportToCSV);
            ExportToTXTCommand = new DelegateCommand(ExportToTXT);

            Products = _productService.ListAllProducts() as List<Product>;
        }


        private List<Product> _products;
        public List<Product> Products
        {
            get
            {
                return _products;
            }
            private set
            {
                _products = value;
                RaisePropertyChanged(nameof(Products));
            }
        }

        private List<Product> _selectedRows;
        public List<Product> SelectedRows
        {
            get { return _selectedRows; }
            set
            {
                _selectedRows = value;
                RaisePropertiesChanged(nameof(SelectedRows));
            }
        }

        #region commands
        public DelegateCommand ExportToCSVCommand { get; }
        public DelegateCommand ExportToTXTCommand { get; }

        /// <summary>
        /// Export the datas of selected row(s) to CSV format 
        /// </summary>
        private void ExportToCSV()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult dialogResult = folderBrowserDialog.ShowDialog();

                if (dialogResult == DialogResult.OK && folderBrowserDialog.SelectedPath != string.Empty)
                {
                    string result = _objectSerializer.ConvertToCSV<Product>(SelectedRows.ToList());

                    bool isFileCreatedSuccessfully = FileOperations.WriteContentToFile(fileContent: result, destination: folderBrowserDialog.SelectedPath, fileName: "\\testCSVFile.csv");

                    if (isFileCreatedSuccessfully)
                        MessageBox.Show("File was downloaded", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        /// <summary>
        /// Export the datas of selected row(s) to TXT format 
        /// </summary>
        private void ExportToTXT()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult dialogResult = folderBrowserDialog.ShowDialog();

                if (dialogResult == DialogResult.OK && folderBrowserDialog.SelectedPath != string.Empty)
                {
                    string result = _objectSerializer.ConvertToTXT<Product>(SelectedRows.ToList());

                    bool isFileCreatedSuccessfully = FileOperations.WriteContentToFile(fileContent: result, destination: folderBrowserDialog.SelectedPath, fileName: "\\testTxtFile.txt");

                    if (isFileCreatedSuccessfully)
                        MessageBox.Show("File was downloaded", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        #endregion
    }
}

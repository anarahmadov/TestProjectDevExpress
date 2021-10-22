using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using TestProjectDevExpress.Models;
using TestProjectDevExpress.Services;
using TestProjectDevExpress.ViewModels;

namespace TestProjectDevExpress.Views
{
    /// <summary>
    /// Interaction logic for View1.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel(new ProductService(), new ObjectSerializer());
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var viewmodel = (MainViewModel)DataContext;

            viewmodel.SelectedRows = listView.SelectedItems
                .Cast<Product>()
                .ToList();
        }
    }

}

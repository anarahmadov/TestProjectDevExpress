using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestProjectDevExpress.Views
{
    /// <summary>
    /// Interaction logic for PersonsUserControl.xaml
    /// </summary>
    public partial class PersonsUserControl : UserControl
    {
        public PersonsUserControl()
        {
            InitializeComponent();
            DataContext = new Person(12, "Anar", "Ahmadov");
        }
    }

    class Person
    {
        public Person(int personId, string firstname, string lastname)
        {
            PersonId = personId;
            FirstName = firstname;
            LastName = lastname;
        }

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

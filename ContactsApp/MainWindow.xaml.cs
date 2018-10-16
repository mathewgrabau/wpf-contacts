using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SQLite;

using ContactsApp.Classes;

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ReadDatabase();
        }

        private void _newContactButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the window for inputting the data
            var newContactWindow = new NewContactWindow();
            newContactWindow.ShowDialog();

            ReadDatabase();
        }

        void ReadDatabase()
        {
            List<Contact> contacts = null;

            using (var connection = new SQLiteConnection(App.DatabasePath))
            {
                connection.CreateTable<Contact>();
                // Grabbing the data here.
                contacts = connection.Table<Contact>().ToList();
            }

            if (contacts != null)
            {
                // Prevents the list from getting duplicate entries
                _contactListView.ItemsSource = contacts;
            }
        }
    }
}

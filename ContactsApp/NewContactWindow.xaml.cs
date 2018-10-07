using ContactsApp.Classes;
using System;
using System.IO;
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
using System.Windows.Shapes;
using SQLite;

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for NewContactWindow.xaml
    /// </summary>
    public partial class NewContactWindow : Window
    {
        public NewContactWindow()
        {
            InitializeComponent();
        }

        private void _saveButton_Click(object sender, RoutedEventArgs e)
        {
            // Saving the information here.
            var contact = new Contact()
            {
                Name = _nameTextBox.Text,
                Email = _emailTextBox.Text,
                PhoneNumber = _emailTextBox.Text
            };

            using (var connection = new SQLiteConnection(App.DatabasePath))
            {
                connection.CreateTable<Contact>();
                // This will determine the destination table based on the type of the object.
                connection.Insert(contact);
            }

            Close();
        }
    }
}

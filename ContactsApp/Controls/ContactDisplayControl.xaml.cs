using ContactsApp.Classes;
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

namespace ContactsApp.Controls
{
    /// <summary>
    /// Interaction logic for ContactDisplayControl.xaml
    /// </summary>
    public partial class ContactDisplayControl : UserControl
    {
        private Contact contact;

        public Contact Contact
        {
            get => contact;
            set
            {
                contact = value;
                nameTextBlock.Text = contact.Name;
                phoneTextBlock.Text = contact.PhoneNumber;
                emailTextBlock.Text = contact.Email;
            }
        }

        // Needed for the binding here.

        public ContactDisplayControl()
        {
            InitializeComponent();
        }
    }
}

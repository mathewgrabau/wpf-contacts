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
        public Contact Contact
        {
            get => (Contact)GetValue(ContactProperty);
            set => SetValue(ContactProperty, value);
        }

        // Needed for the binding here.
        public static readonly DependencyProperty ContactProperty =
            DependencyProperty.Register("Contact", typeof(Contact), typeof(ContactDisplayControl), 
                new PropertyMetadata(null, SetTextValues));

        // Meta-data ends up defining the gathering/responding for data changing

        public ContactDisplayControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Type of the contact infomration for this.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void SetTextValues(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ContactDisplayControl instance)
            {
                if (e.NewValue is Contact newValue)
                {
                    instance.nameTextBlock.Text = newValue.Name;
                    instance.phoneTextBlock.Text = newValue.PhoneNumber;
                    instance.emailTextBlock.Text = newValue.Email;
                }
            }
        }

    }
}

using SQLite;

namespace ContactsApp.Classes
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        // Override for better display of the item
        public override string ToString()
        {
            return $"{Name} - {Email} - {PhoneNumber}";
        }
    }

    // The Indexed property is used with FK modelling on SQLite
}

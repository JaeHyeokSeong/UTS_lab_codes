using System.Collections;

namespace Program1
{
    public class Contact
    {
        private string name, phoneNumber;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public Contact(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return "Name: " + name + ", Phone: " + phoneNumber;
        }
    }
    public class Contacts : IEnumerable<Contact>
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }
        public IEnumerator<Contact> GetEnumerator()
        {
            return contacts.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // [1] Initialise
            Contacts contacts = new Contacts();
            contacts.AddContact(new Contact("a", "123456789"));
            contacts.AddContact(new Contact("b", "125656789"));
            contacts.AddContact(new Contact("c", "789456789"));
            contacts.AddContact(new Contact("d", "123676789"));

            // [2] Process
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact.ToString());
            }

            // [3] Output
            // Name: a, Phone: 123456789
            // Name: b, Phone: 125656789
            // Name: c, Phone: 789456789
            // Name: d, Phone: 123676789

            // Reference : https://stackoverflow.com/questions/11296810/how-do-i-implement-ienumerablet


        }
    }
}
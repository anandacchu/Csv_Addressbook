namespace AddressBookSystem
{
    class Program
    {
        //creating list of contact
        public static List<Contact> contactList = new List<Contact>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Sytem.");

            //ability to creating contacts
            Contact contact1 = new Contact();
            contact1.firstName ="Anand";
            contact1.lastName = "manali";
            contact1.address = "Harur tamilnadu";
            contact1.phone = 1234567890;
            contact1.city = "Harur";
            contact1.state = "Tamilnadu";
            contact1.zipcode = 636903;
            contactList.Add(contact1);

        }
    }
}

namespace AdressManagementBook
{
    class Program
    {


        public static List<Person> People = new List<Person>();
        public static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Adress Book");

            string EnterKey = "";
            while (EnterKey != "Exit")
            {
                Console.WriteLine("Enter the key ADD or DELETE or Exit to manage Your Adress Book");
                EnterKey = Console.ReadLine();

                switch (EnterKey)
                {
                    case "ADD":
                        AddPerson();
                        break;
                    case "DELETE":
                        RemovePerson();
                        break;
                 }
            }
        }
            private static void AddPerson()
            {
                Person person = new Person();

                Console.Write("Enter First Name: ");
                person.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                person.PhoneNumber = Console.ReadLine();

                Console.Write("Enter Address : ");
                person.Adress = Console.ReadLine();

                Console.WriteLine("Enter City: ");
                person.City = Console.ReadLine();

                Console.WriteLine("Enter State: ");
                person.State = Console.ReadLine();

                Console.WriteLine("Enter Email: ");
                person.Email = Console.ReadLine();

                People.Add(person);
            }


            private static void RemovePerson()
            {
                List<Person> people = FindPeopleByFirstName();

                Console.Clear();

                if (people.Count == 0)
                {
                    Console.WriteLine("That person could not be found. Press any key to continue");
                    Console.ReadKey();
                    return;
                }

                if (people.Count == 1)
                {
                    RemovePersonFromList(people.Single());
                    return;
                }

            }
            private static void RemovePersonFromList(Person person)
            {
                Console.Clear();
                Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
                PrintPerson(person);

                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    People.Remove(person);
                    Console.Clear();
                    Console.WriteLine("Person removed. Press any key to continue.");
                    Console.ReadKey();
                }
            }
            private static List<Person> FindPeopleByFirstName()
            {
                Console.Clear();
                Console.WriteLine("Enter the first name of the person you would like to find.");
                string firstName = Console.ReadLine();
                return People.Where(x => x.FirstName.ToLower() == firstName.ToLower()).ToList();
            }
            private static void PrintPerson(Person person)
            {
                Console.WriteLine("First Name: " + person.FirstName);
                Console.WriteLine("Last Name: " + person.LastName);
                Console.WriteLine("Phone Number: " + person.PhoneNumber);
                Console.Write("Enter Address : " + person.Adress);
                Console.WriteLine("Enter Email: " + person.Email);
                Console.WriteLine("Enter State: " + person.State);
                Console.WriteLine("Enter City: " + person.City);
            
            }

        }
    }


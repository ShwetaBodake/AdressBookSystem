namespace AdressManagementBook
{
    class Program
    {


        public static List<Person> People = new List<Person>();

        public static void Main(string[] args)
        {
            { Console.WriteLine("WelCome to Adress Book"); }
            for (int i = 1; i <= 5; i++)
            {
                AddPerson();
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

        }

    }


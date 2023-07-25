using ConsoleBankProject.Entities;

namespace ConsoleBankProject.Service
{
    public static class UserServices
    {
       
        public static void CreatNewUser()
        {
            
            Console.WriteLine("Please Enter Your First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter Your Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please Enter Your email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Please Enter Your Phone Number");
            string phoneNumber = Console.ReadLine();

            User newUser = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber
            };

            string registrationDetails = " ";
            if (firstName != null && lastName != null && email != null && phoneNumber != null)
            {
                registrationDetails += $"Hello {firstName} {lastName}\n";
                registrationDetails += $"Here is your email address {email}\n";
                registrationDetails += $"Here is your phone number {phoneNumber} \n";
            }

            string directoryPath = @"C:\Users\marvelous.abolade\Documents\AfricaPrudential\AfricaPrudential Projects\ConsoleBankProject\ConsoleBankProject\Data\Files\";
            string filePath = Path.Combine(directoryPath, "Users.txt");

            Directory.CreateDirectory(directoryPath);

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(registrationDetails);
                sw.Dispose();
            }
            Console.WriteLine($"{registrationDetails}");

        }
        public static void GetAccountName()
        {
            
        }
    }
}

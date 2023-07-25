using ConsoleBankProject.Service;

UserServices.CreatNewUser();

AccountService.CreateAccount();

//AccountService.DepositFunds();

//AccountService.WithdrawFunds();







































// Create new user 

/*User newUser = new User();
var userId = Guid.NewGuid().ToString();
Console.WriteLine("Enter a new name:");
string firstName = Console.ReadLine()!.Trim();
Console.WriteLine("Please Enter Last Name");    
string lastName = Console.ReadLine()!.Trim();
*//*Console.WriteLine("Enter Phone Number");
string phoneNumber = Console.ReadLine()!.Trim();
Console.WriteLine("Please Enter Email");
string email = Console.ReadLine()!.Trim();*//*

var newUserDetails = $"User information: Firstname : {firstName}, Lastname : {lastName}";
//var newUserDetails = $"User information: Firstname : {firstName}, Lastname : {lastName}, Email : {email}, PhoneNumber : {phoneNumber}";

Account newAccount = new Account();
Console.WriteLine("Please Enter Account Type");
string accountType = Console.ReadLine()!.Trim();
Console.WriteLine("Please Enter Account Balance");
double accountBalance =double.Parse(Console.ReadLine());

Console.WriteLine("Please Enter a Summarry");
string summary = Console.ReadLine();
    
var accDetails = $"Account Detail: Account Type: {accountType}, Account Balance {accountBalance}, Account Summary: {summary}"; 



string directoryPath = @"C:\Users\marvelous.abolade\Documents\AfricaPrudential\AfricaPrudential Projects\ConsoleBankProject\ConsoleBankProject\Data\Files\";
string filePath = Path.Combine(directoryPath, "Names.txt");

Directory.CreateDirectory(directoryPath);

using (StreamWriter sw = new StreamWriter(filePath, true))
{
    sw.WriteLine(newUserDetails);
    sw.WriteLine(accDetails);
    sw.Dispose();
}
Console.WriteLine($"{newUserDetails} has been added to the file");
Console.WriteLine($"{accDetails} has been added to the file");*/
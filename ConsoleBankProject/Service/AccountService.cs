using ConsoleBankProject.Entities;
using Newtonsoft.Json;

namespace ConsoleBankProject.Service
{
    public class AccountService
    {   
        public static void CreateAccount()
        {
            Random random = new Random();

            int accountNumber = random.Next(100000, 999999);
            Console.WriteLine("Account Number: " + accountNumber);

           

            Account newAccount = new Account()
            {
                AccountName = "Abolade Bolu Marvelous",
                AccountNumber = accountNumber,
                CurrentAccount = 0,
                SavingsAccount = 1000
            };

            string directoryPath = @"C:\Users\marvelous.abolade\Documents\AfricaPrudential\AfricaPrudential Projects\ConsoleBankProject\ConsoleBankProject\Data\Files\";
            string filePath = Path.Combine(directoryPath, "Accounts.txt");

            Directory.CreateDirectory(directoryPath);

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                string convertNewAccount = JsonConvert.SerializeObject(newAccount);
                sw.WriteLine($"{convertNewAccount}");
            }

            Console.WriteLine("Account details have been saved to the file.");
        }
        //Parameters : decimal amountNumber, DateTime date, string note
        public static async void DepositFunds()
        {

            // get current account
            string directoryPath = @"C:\Users\marvelous.abolade\Documents\AfricaPrudential\AfricaPrudential Projects\ConsoleBankProject\ConsoleBankProject\Data\Files\";
            string filePath = Path.Combine(directoryPath, "Accounts.txt");

            string accountDetail;
            using (StreamReader sw = new StreamReader(filePath))
            {
                accountDetail = $"[{ await sw.ReadLineAsync()}]";
            }
            // Convert obtained details to an Object
            List<Account> account = JsonConvert.DeserializeObject<List<Account>>(accountDetail);
            var userAccount = account.Find(user => user.AccountNumber == 637581.0);

            double amount;
            Console.WriteLine("Enter Amount You want to deposit");
            double.TryParse(Console.ReadLine(), out amount);

            userAccount.SavingsAccount = userAccount.SavingsAccount+amount;
            string  jsonContent = JsonConvert.SerializeObject(account);
            File.WriteAllText(filePath, jsonContent);

        }
        public static async void WithdrawFunds()
        {
            string directoryPath = @"C:\Users\marvelous.abolade\Documents\AfricaPrudential\AfricaPrudential Projects\ConsoleBankProject\ConsoleBankProject\Data\Files\";
            string filePath = Path.Combine(directoryPath, "Accounts.txt");

            string accountDetail;
            using (StreamReader sw = new StreamReader(filePath))
            {
                accountDetail = await sw.ReadToEndAsync();
            }

            List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(accountDetail);
            Account userAccount = accounts.Find(user => user.AccountNumber == 637581.0);

            if (userAccount == null)
            {
                Console.WriteLine("User account not found.");
                return;
            }

            Console.WriteLine("Enter Amount You want to Withdraw");
            double amount;
            if (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
                return;
            }

            if (userAccount.CurrentAccount >= amount || userAccount.SavingsAccount >= amount)
            {
                userAccount.CurrentAccount -= amount;
                string jsonContent = JsonConvert.SerializeObject(accounts);
                File.WriteAllText(filePath, jsonContent);

                Console.WriteLine("Withdrawal successful. Updated account details have been saved.");
            }
            else
            {
                Console.WriteLine("Insufficient balance for withdrawal.");
            }

        }
       /* public static void TransferFunds(decimal amount, DateTime date, string note)
        {
            string directoryPath = @"C:\Users\marvelous.abolade\Documents\AfricaPrudential\AfricaPrudential Projects\ConsoleBankProject\ConsoleBankProject\Data\Files\";
            string filePath = Path.Combine(directoryPath, "Accounts.txt");

            string accountDetail;
            using (StreamReader sw = new StreamReader(filePath))
            {
                accountDetail = sw.ReadToEnd();
            }
            List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(accountDetail);

            Account sourceAccount = accounts.Find(user => user.AccountNumber == 637581.0);
            Account targetAccount = accounts.Find(user => user.AccountNumber == "target");

            if (sourceAccount == null || targetAccount == null)
            {
                Console.WriteLine("Invalid source or target account number.");
                return;
            }

            if (sourceAccount.CurrentAccount + sourceAccount.SavingsAccount >= amount)
            {
                if (sourceAccount.SavingsAccount >= amount)
                {
                    sourceAccount.CurrentAccount -= amount;
                }
                else
                {
                    {
                        decimal remainingAmount = amount - sourceAccount.CurrentAccount;
                        sourceAccount.CurrentAccount = 0;
                        sourceAccount.SavingsAccount -= remainingAmount;
                    }
                    targetAccount.SavingsAccount = +amount;

                    string jsonContent = JsonConvert.SerializeObject(accounts);
                    File.WriteAllText(filePath, jsonContent);

                    Console.WriteLine("Transfer successful, Updated account details have been saved.");

                }            
            }
            else
            {
                Console.WriteLine("Insufficient balance for the transfer.");
            }
        }*/
    }
}






   


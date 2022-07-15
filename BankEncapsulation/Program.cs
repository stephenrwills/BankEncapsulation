using BankEncapsulation;

var myAccount = new BankAccount();

Console.WriteLine($"Your balance is {myAccount.GetBalance}");

Console.WriteLine("How much would you like to deposit?");

var depositAmount = double.Parse(Console.ReadLine());

myAccount.Deposit(depositAmount);

Console.WriteLine("Please enter the amount you would like to withdraw:");

var withdrawAmount = double.Parse(Console.ReadLine());
myAccount.Withdraw(withdrawAmount);

Console.WriteLine($"Thank you for your deposit! Your balance is now {myAccount.GetBalance}");




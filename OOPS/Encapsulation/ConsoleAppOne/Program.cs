using ConsoleAppOne.src.OopPrinciples.Encapsulation;
// using ConsoleAppOne.src.OopPrinciples.Encapsulation;

// BadBankAccount badAccount = new BadBankAccount();

// badAccount.balance = -50;

// if (badAccount.balance < 0)
// {
//     System.Console.WriteLine("Balance could not be in negative numbers");
// }
// else
// {
//     System.Console.WriteLine(badAccount.balance);
// }



/// Encapsulation

BackAccount bankAccount = new BackAccount(10);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.WithDraw(20);

System.Console.WriteLine(bankAccount.GetBalance());




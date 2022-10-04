namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Gandalf", 100000);
            Console.Write($"Account {account.Number} was created for {account.Owner} ");
            Console.Write($"with {account.Balance} gold coins");


            account.MakeWithdrawal(120, DateTime.Now, "Broom");
            Console.WriteLine();
            Console.WriteLine("Your balance is: " + account.Balance);


        }
    }
}
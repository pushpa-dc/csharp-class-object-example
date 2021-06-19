namespace ClassAndObject
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; } = 100;

        //    , Debit(decimal amount), Tranfer(int anotherAccountId)

        public decimal Credit(decimal amount)
        {
            return (Balance + amount);
        }

        public void Debit(decimal amount)
        {
            if(amount <= Balance)
            {
                Balance = Balance - amount;
                System.Console.WriteLine($"You have withdraw {Balance}");;

            }
            System.Console.WriteLine("In sufficent balance in your account.");
        }

        public void Transfer(int anotherAccountId, double amount)
        {
            System.Console.WriteLine($"successfully transferring {amount} to Id: {anotherAccountId}  ");
        }


    }
}
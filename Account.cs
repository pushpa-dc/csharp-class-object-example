namespace ClassAndObject
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; } = 1000;

        //    , Debit(decimal amount), Tranfer(int anotherAccountId)

        public decimal Credit(decimal amount)
        {
            return (Balance + amount);
        }

        public void Debit(decimal amount)
        {
            if(amount <= Balance)
            {
                Balance -= amount;
                System.Console.WriteLine($"You have withdraw {amount} total amount is {Balance}");

            }else{
            System.Console.WriteLine("In sufficent balance in your account.");

            }
        }

        public void Transfer(int anotherAccountId, decimal amount)
        {
            if(amount<=Balance){
                Balance -= amount;
                System.Console.WriteLine($"successfully transferring {amount} to Id: {anotherAccountId} new balance is : ${Balance}  ");
            }else{
                System.Console.WriteLine($"Insufficient balance {Balance} ");
            }


        }


    }
}
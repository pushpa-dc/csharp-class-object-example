using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {

            // For Employee

            // Console.WriteLine("Enter first Name");
            // var firstName = Console.ReadLine();

            // System.Console.WriteLine("Enter last name");
            // var lastName = Console.ReadLine();


            // System.Console.WriteLine("Enter Monlty salary");
            // var montlySalary = double.Parse(Console.ReadLine());

            // System.Console.WriteLine("Enter riased %");
            // var raisedPercentage = int.Parse(Console.ReadLine());


            // var employee = new Employee()
            // {
            //     FirstName = firstName,
            //     LastName = lastName,
            //     Salary = montlySalary
            // };

            // System.Console.WriteLine($"Your full name is : {employee.GetFullName()}");
            // System.Console.WriteLine($"Your annual salary is : ${employee.GetAnnualSalary()}");
            // System.Console.WriteLine($"Your raised salary is : ${employee.RaisedSalary(5)}");

            //for InvoiceItem

            // System.Console.WriteLine("Enter Id");
            // var id = int.Parse(System.Console.ReadLine());

            // System.Console.WriteLine("Enter description: ");
            // var desc = System.Console.ReadLine();

            // System.Console.WriteLine("Enter Quantity");
            // var quantity = int.Parse(System.Console.ReadLine());

            // System.Console.WriteLine("Enter Rate");
            // var rate = int.Parse(System.Console.ReadLine());


            // var invoiceItem = new InvoiceItem
            // {
            //     Id = id,
            //     Description = desc,
            //     Quantity = quantity,
            //     Rate = rate
            // };


            // System.Console.WriteLine($"Total is : {invoiceItem.GetTotal()}");


            //For Account
            System.Console.WriteLine("Enter Name : ");
            var name = System.Console.ReadLine();

            System.Console.WriteLine("Enter amount to deposit : ");
            var amount = decimal.Parse(System.Console.ReadLine());



            var account = new Account
            {
                Name = name
            };


            System.Console.WriteLine($"Your total Balance in your account is {account.Credit(amount)}");


            


            System.Console.WriteLine("Enter withdraw amount: ");
            var amountToWitdraw = decimal.Parse(System.Console.ReadLine());

            account.Debit(amountToWitdraw);

            System.Console.WriteLine("Enter account id");
            var id = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Enter ammount for transfer to another");
            var amountToTransfer = int.Parse(System.Console.ReadLine());

            account.Transfer(id,amountToTransfer);
        }
    }
}

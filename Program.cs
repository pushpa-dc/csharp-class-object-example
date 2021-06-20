using System;
using System.Collections.Generic;

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

            List<InvoiceItem> invoices = new List<InvoiceItem>();

            System.Console.WriteLine("How many invoices do you want to add ?");
            var length = int.Parse(System.Console.ReadLine());
            int i = 0;

            while (i < length)
            {
                System.Console.WriteLine("Enter Id");
                var id = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Enter description: ");
                var desc = System.Console.ReadLine();

                System.Console.WriteLine("Enter Quantity");
                var quantity = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Enter Rate");
                var rate = int.Parse(System.Console.ReadLine());


                var invoiceItem = new InvoiceItem
                {
                    Id = id,
                    Description = desc,
                    Quantity = quantity,
                    Rate = rate
                };


                invoices.Add(invoiceItem);
                i++;
            }


            Console.WriteLine("{0,0}\t{1,10}\t{2,5}\t{3,10}\t{4,10}", "ID", "Description", "Quantity", "Rate", "Subtotal");
            foreach (var invoice in invoices)
            {
              Console.WriteLine("{0,0}\t{1,10}\t{2,5}\t{3,10}\t{4,10}", invoice.Id, invoice.Description, invoice.Quantity, invoice.Rate, invoice.Rate * invoice.Quantity);
            }
            System.Console.Write("---------------------------------------------------");

            double total = 0;

            foreach (var invoice in invoices)
            {
                total += invoice.GetTotal();
            }

            System.Console.WriteLine($" Total {total}");


            //For Account
            // System.Console.WriteLine("Enter Name : ");
            // var name = System.Console.ReadLine();

            // System.Console.WriteLine("Enter amount to deposit : ");
            // var amount = decimal.Parse(System.Console.ReadLine());



            // var account = new Account
            // {
            //     Name = name
            // };


            // System.Console.WriteLine($"Your total Balance in your account is {account.Credit(amount)}");





            // System.Console.WriteLine("Enter withdraw amount: ");
            // var amountToWitdraw = decimal.Parse(System.Console.ReadLine());

            // account.Debit(amountToWitdraw);

            // System.Console.WriteLine("Enter account id");
            // var id = int.Parse(System.Console.ReadLine());

            // System.Console.WriteLine("Enter ammount for transfer to another");
            // var amountToTransfer = int.Parse(System.Console.ReadLine());

            // account.Transfer(id,amountToTransfer);
        }
    }
}

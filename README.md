# csharp-class-object-example
C# class and object for beginners examples

Questions:

Create class and demonstrate their usage for the following entities
1. Employee
Id, FirstName, LastName, Email, Salary
GetFullName(), GetAnnualSalary(), RaiseSalary(int percent)


2. InvoiceItem
Id, Description, Quantity, Rate
GetTotal()


3. Account
Id, Name, Balance
Credit(decimal amount), Debit(decimal amount), Tranfer(int anotherAccountId)
(Hint: Credit : Balance + amount, Debit : if amount <= Balance then Balance-amount else error)

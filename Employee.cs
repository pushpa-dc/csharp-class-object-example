namespace ClassAndObject
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }


        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }


        public double GetAnnualSalary()
        {
            return (Salary * 12);
        }

        public double RaisedSalary(int percent)
        {

            var percentToDecimal =(double) percent / (double) 100;
            return (GetAnnualSalary() + GetAnnualSalary() * percentToDecimal);
            
        }
    }
}
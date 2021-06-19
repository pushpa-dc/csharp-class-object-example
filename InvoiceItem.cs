namespace ClassAndObject
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int  Quantity { get; set; }
        public int Rate { get; set; }

        public double GetTotal()
        {
            return Quantity * Rate;
            
        }

    }
}
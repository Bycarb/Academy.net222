using System;

namespace Academy.Common.Entities
{
    public class Rental
    {
        int ID;
        DateTime From { get; set; }
        public DateTime To
        {
            get { return From.AddDays(Days); }
        }
        public int Days { get; set; }
        public Person Customer { get; set; }
        public Vehicle Vehicle { get; set; }

        public double Price
        {
            get
            {
                return (Vehicle == null) ? (0) : (Days * Vehicle.DailyPrice);
            }
        }

        public Rental(int iD, DateTime from, int days, Person customer, Vehicle vehicle)
        {
            ID = iD;
            From = from;
            Days = days;
            Customer = customer;
            Vehicle = vehicle;
        }

        public override string ToString()
        {
            return $"Noleggio {ID} \n" +
                $"Inizio {From} \n" +
                $"Fine {To}\n" +
                $"Cliente {Customer.Name}\n" +
                $"Costo {Price:C}";
        }
    }
}

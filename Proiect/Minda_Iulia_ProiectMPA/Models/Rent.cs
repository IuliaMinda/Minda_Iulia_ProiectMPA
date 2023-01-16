namespace Minda_Iulia_ProiectMPA.Models
{
    public class Rent
    {
        public int RentID { get; set; }
        public int CustomerID { get; set; }
        public int CarID { get; set;  }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }   

        public Customer Customer { get; set; }
        public Car Car { get; set; }       

    }
}

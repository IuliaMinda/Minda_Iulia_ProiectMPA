namespace Minda_Iulia_ProiectMPA.Models
{
    public class Customer
    {
        public int CustomerID { get; set; } 
        public int CardID { get; set; } 
        public string FirstName  { get; set; }  
        public string LastName { get; set; }    

        public Card Card { get; set; }
    }
}

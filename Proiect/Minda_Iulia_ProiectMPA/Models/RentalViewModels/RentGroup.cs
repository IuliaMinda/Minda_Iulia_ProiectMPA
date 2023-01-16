using System.ComponentModel.DataAnnotations;

namespace Minda_Iulia_ProiectMPA.Models.RentalViewModels
{
    public class RentGroup
    {
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }    
    }
}

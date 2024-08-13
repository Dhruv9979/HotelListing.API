using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Models.Hotel
{
    public class HotelDTO : BaseHotelDTO
    {
        public int Id { get; set; }
    }
}

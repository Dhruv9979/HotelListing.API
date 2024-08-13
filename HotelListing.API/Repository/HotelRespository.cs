using HotelListing.API.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Repository
{
    public class HotelRespository : GenericRespository<Hotel>, IHotelsRepository
    {
        public HotelRespository(HotelListingDbContext context) : base(context)
        {
        }
    }
}


namespace MBath.Server.Services.AddressService
{
    public class AddressSrvc : IAddressSrvc
    {
        private readonly DataContext _context;
        private readonly IAuthenticationSrvc _authentication;

        public AddressSrvc(DataContext context, IAuthenticationSrvc authentication)
        {
            _context = context;
            _authentication = authentication;
        }
        public async Task<ServiceResponse<Address>> GetAddress()
        {
            int userId = _authentication.GetUserId();
            var address = await _context.Addresses.FirstOrDefaultAsync(a=>a.UserId == userId);

            return new ServiceResponse<Address> { Data = address };
        }

        public async Task<ServiceResponse<Address>> UpdateAddress(Address address)
        {
            var response = new ServiceResponse<Address>();

            var dbAddress = (await GetAddress()).Data;

            if(dbAddress == null)
            {
                var id =  _authentication.GetUserId();
                address.UserId = id;
               _context.Addresses.Add(address);
               response.Data = address;
            }
            else
            {
                dbAddress.FirstName= address.FirstName;
                dbAddress.LastName= address.LastName;
                dbAddress.Street= address.Street;
                dbAddress.City= address.City;
                dbAddress.State= address.State;
                dbAddress.PostalCode= address.PostalCode;
                dbAddress.Country= address.Country;


            }
            await _context.SaveChangesAsync();
            return response;
        }
    }
}

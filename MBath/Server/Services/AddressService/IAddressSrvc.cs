
namespace MBath.Server.Services.AddressService
{
    public interface IAddressSrvc
    {

        Task<ServiceResponse<Address>> GetAddress();

        Task<ServiceResponse<Address>> UpdateAddress(Address address);
    }
}

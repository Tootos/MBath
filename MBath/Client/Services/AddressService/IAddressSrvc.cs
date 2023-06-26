namespace MBath.Client.Services.AddressService
{
    public interface IAddressSrvc
    {
        Task<Address> GetAddressAsync();

        Task<Address> UpdateAddressAsync(Address address);
    }
}

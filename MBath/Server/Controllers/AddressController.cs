
using Microsoft.AspNetCore.Mvc;

namespace MBath.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressSrvc _addressService;

        public AddressController(IAddressSrvc addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<Address>>> GetAddress()
        {
            var result= await _addressService.GetAddress();
            return Ok(result);
        }


        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Address>>> UpdateAddress(Address address)
        {
            var result = await _addressService.UpdateAddress(address);
            return Ok(result);
        }
    }
}

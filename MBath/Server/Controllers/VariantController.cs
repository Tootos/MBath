
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MBath.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VariantController : ControllerBase
    {
        private readonly IVariantSrvc _variantService;

        public VariantController(IVariantSrvc variantService)
        {
            _variantService = variantService;
        }

        [HttpGet("admin"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<Variant>>>> GetAdminVariants()
        {
            var result= await _variantService.GetAdminVariants();
            return Ok(result);
        }

        [HttpPost("admin"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<Variant>>> CreateVariant([FromBody] string variantName)
        {
            var result = await _variantService.CreateVariant(variantName);
            return Ok(result);
        }

        [HttpPut("admin"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<Variant>>> UpdateVariant(Variant variant)
        {
            var result = await _variantService.UpdateVariant(variant);
            return Ok(result);
        }
    }
}

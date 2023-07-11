namespace MBath.Server.Services.VariantService
{
    public interface IVariantSrvc
    {
        Task<ServiceResponse<List<Variant>>> GetAdminVariants();
        Task<ServiceResponse<Variant>> CreateVariant(string variantName);
        Task<ServiceResponse<List<Variant>>> UpdateVariant(Variant variant);


    }
}

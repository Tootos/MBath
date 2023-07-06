namespace MBath.Client.Services.VariantService
{
    public interface IVariantSrvc
    {
        List<Variant> AdminVariants { get; set; }
        event Action VariantsChanged;
        Task GetVariantsAsync();

        Task<Variant> CreateVariantAsync(string variantName);

        Task UpdateVariantAsync(Variant variant);
    }
}

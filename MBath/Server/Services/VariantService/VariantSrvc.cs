namespace MBath.Server.Services.VariantService
{
    public class VariantSrvc : IVariantSrvc
    {
        private readonly DataContext _context;

        public VariantSrvc(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<Variant>> CreateVariant(string variantName)
        {
            Variant variant = null;

            variant = await _context.Variants.FirstOrDefaultAsync(x => x.Name == variantName);

            if (variant != null)
                return new ServiceResponse<Variant> { Data=variant };

            variant = new Variant
            {
                Name = variantName,
                IsNew = false
            };

            await _context.Variants.AddAsync(variant);
            await _context.SaveChangesAsync();

            return new ServiceResponse<Variant>
            {
                Data = variant
            };
        }

        public async Task<ServiceResponse<List<Variant>>> GetAdminVariants()
        {
            var response = new ServiceResponse<List<Variant>>
            {
                Data = await _context.Variants.Where(v => !v.Deleted).ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Variant>>> UpdateVariant(Variant variant)
        {
            var dbVariant = await _context.Variants.FindAsync(variant);


            if (dbVariant == null)
            {
                return new ServiceResponse<List<Variant>>
                {
                    Success = false,
                    Message = "Variant not found."
                };
            }

            dbVariant.Name= variant.Name;
            dbVariant.Description= variant.Description;
            dbVariant.Visible= variant.Visible;


            return await GetAdminVariants();
        }
    }
}

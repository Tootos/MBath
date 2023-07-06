using System.Net.Http.Json;

namespace MBath.Client.Services.VariantService
{
    public class VariantSrvc : IVariantSrvc
    {
        private readonly HttpClient _http;

        public List<Variant> AdminVariants { get; set; }

        public event Action VariantsChanged;

        public VariantSrvc(HttpClient http)
        {
            _http = http;
        }

        public async Task GetVariantsAsync()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Variant>>>("api/variant/admin");
            
            if(result!=null && result.Data!=null)
            {
                AdminVariants = result.Data;
            }
        }

        public async Task<Variant> CreateVariantAsync(string variantName)
        {
            var result = await _http.PostAsJsonAsync("api/Variant/admin", variantName);
            var newVariant= (await result.Content.ReadFromJsonAsync<ServiceResponse<Variant>>()).Data;
            return  newVariant;
        }

        public async Task UpdateVariantAsync(Variant variant)
        {
            var result = await _http.PutAsJsonAsync("api/Variant/admin", variant);
        }
    }
}

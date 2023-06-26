using System.Net.Http.Json;

namespace MBath.Client.Services.CartService
{
    public class CartSrvc :ICartSrvc
    {
        private readonly ILocalStorageService _localStorage;
        private readonly HttpClient _http;
        private readonly IAuthenticationSrvc _authentication;

        public event Action OnChange;

        public CartSrvc(ILocalStorageService localStorage, HttpClient http,
            IAuthenticationSrvc authentication)
        {
            _localStorage = localStorage;
            _http = http;
            _authentication = authentication;
        }

        

        public async Task AddToCartAsync(CartItem item)
        {

            if (await _authentication.IsAuthenticated())
            {
                await _http.PostAsJsonAsync("api/cart/add", item);
            }
            else
            {
                var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");

                if (cart == null)
                {
                    cart = new List<CartItem>();
                }

                var sameItem = cart
                    .Find(c => c.ProductId == item.ProductId && c.VariantId == item.VariantId);
                if (sameItem == null)
                {
                    cart.Add(item);
                }
                else
                {
                    sameItem.Quantity += item.Quantity;
                }

                await _localStorage.SetItemAsync("cart", cart);
            }
            
            await GetCartItemsCount();
        }


        public async Task<List<CartProductResponse>> GetCartProductsAsync()
        {
            if(await _authentication.IsAuthenticated())
            {
                var response = await _http.GetFromJsonAsync<ServiceResponse<List<CartProductResponse>>>("api/cart");
                return response.Data;
            }
            var cartItems = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cartItems == null)            
                return new List<CartProductResponse>();

            var cartProducts = await _http.PostAsJsonAsync("api/car/products", cartItems);

            var result = await cartProducts.Content.ReadFromJsonAsync<ServiceResponse<List<CartProductResponse>>>();
            
             return result.Data;
            
            
        }

        public async Task RemoveProductFromCartAsync(int productId, int variantId)
        {
            if(await _authentication.IsAuthenticated())
            {
                await _http.DeleteAsync($"api/cart/{productId}/{variantId}");
            }
            else
            {
                var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
                if (cart == null)
                {
                    return;
                }

                var cartItem = cart
                    .Find(c => c.ProductId == productId && c.VariantId == variantId);
                if (cartItem != null)
                {
                    cart.Remove(cartItem);
                    await _localStorage.SetItemAsync("cart", cart);
                    
                }
            }
        }

        public async Task UpdateQuantity(CartProductResponse product)
        {
            if (await _authentication.IsAuthenticated())
            {
                var request = new CartItem
                {
                    ProductId = product.ProductId,
                    VariantId = product.VariantId,
                    Quantity = product.Quantity
                };

                await _http.PutAsJsonAsync("api/cart/update-quantity",request);
            }
            else
            {
                var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
                if (cart == null)
                {
                    return;
                }

                var cartItem = cart
                    .Find(c => c.ProductId == product.ProductId && c.VariantId == product.VariantId);
                if (cartItem != null)
                {
                    cartItem.Quantity += product.Quantity;
                    await _localStorage.SetItemAsync("cart", cart);
                }
            }
    
        }       

        public async Task StoreCartItems(bool emptyLocalCart= false)
        {
            var localCart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if(localCart== null)
            {
                return;
            }

            await _http.PostAsJsonAsync("api/cart",localCart);

            if (emptyLocalCart)
                await _localStorage.RemoveItemAsync("cart");
        }

        public async Task GetCartItemsCount()
        {
            if(await _authentication.IsAuthenticated())
            {
                var result = await _http.GetFromJsonAsync<ServiceResponse<int>>("api/cart/count");
                var count = result.Data;

                await _localStorage.SetItemAsync<int>("cartItemsCount", count);
            }
            else
            {
                var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
                await _localStorage.SetItemAsync<int>("cartItemsCount",cart!=null? cart.Count : 0);
            }

            OnChange.Invoke();
        }
    }
}

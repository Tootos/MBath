

namespace MBath.Server.Services.OrderService
{
    public class OrderSrvc : IOrderSrvc
    {
        private readonly DataContext _context;
        private readonly ICartSrvc _cartService;
        private readonly IAuthenticationSrvc _authentication;
        

        public OrderSrvc(DataContext context,
            ICartSrvc cartService, 
            IAuthenticationSrvc authentication)
        {
            _context = context;
            _cartService = cartService;
            _authentication = authentication;
        }
        public async Task<ServiceResponse<bool>> CreateOrder(int userId)
        {
            var products = (await _cartService.GetDbCartProducts(userId)).Data;

            decimal finalPrice = 0;

            products.ForEach(p => finalPrice += p.Price * p.Quantity);

            var orderItems= new List<OrderItem>();
            products.ForEach(p => orderItems.Add(new OrderItem
            {
                
                ProductId = p.ProductId,
                VariantId = p.VariantId,
                Quantity = p.Quantity,
                TotalPrice = p.Price *p.Quantity

            })) ;

            var order = new Order
            {
                UserId = userId,
                OrderDate = DateTime.Now,
                TotalPrice= finalPrice,
                OrderItems= orderItems
            };

            _context.Orders.Add(order);

            _context.CartItems.RemoveRange(_context.CartItems
                .Where(ci => ci.UserId == userId));

            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Data=true };
        }

        public async Task<ServiceResponse<OrderDetailsResponse>> GetOrderDetails(int orderId)
        {
            var response = new ServiceResponse<OrderDetailsResponse>();
            var order = await _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product).ThenInclude(p=>p.Images)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Variant)
                .Where(o => o.UserId == _authentication.GetUserId() && o.Id == orderId)
                .OrderBy(o => o.OrderDate).FirstOrDefaultAsync();

            if (order == null)
            {
                response.Message = "Order not found";
                return response;
            }

            var orderDetailsResponse = new OrderDetailsResponse
            {
                OrderDate= order.OrderDate,
                TotalPrice= order.TotalPrice,
                Products= new List<OrderDetailsProductResponse>()
            };

            order.OrderItems.ForEach(oi => orderDetailsResponse.Products.Add(new OrderDetailsProductResponse
            {
                ProductId = oi.ProductId,
                ProductName = oi.Product.Name,
                Quantity = oi.Quantity,
                ImgUrl = oi.Product.ImgURL,
                Images = oi.Product.Images,
                TotalPrice = oi.TotalPrice,
                VariantName = oi.Variant.Name

            })) ;

            response.Data = orderDetailsResponse;

            return response;
        }

        public async Task<ServiceResponse<List<OrderOverviewResponse>>> GetOrderItemsAsync()
        {
            var response= new ServiceResponse<List<OrderOverviewResponse>>();
            var orders = await _context.Orders
                .Include(o=>o.OrderItems)
                .ThenInclude(oi=>oi.Product).ThenInclude(p => p.Images)
                .Where(o=>o.UserId == _authentication.GetUserId())
                .OrderByDescending(o=>o.OrderDate)
                .ToListAsync();

            var orderResponse = new List<OrderOverviewResponse>();
            orders.ForEach(o => orderResponse.Add(new OrderOverviewResponse()
            {
                Id = o.Id,
                OrderDate = o.OrderDate,
                TotalPrice = o.TotalPrice,
                ProductName = o.OrderItems.Count > 1 ?
                $"{o.OrderItems.First().Product.Name} and "+
                $"{o.OrderItems.Count-1} more..." :
                o.OrderItems.First().Product.Name ,
                ProductImgUrl= o.OrderItems.First().Product.ImgURL == ""
                ? o.OrderItems.First().Product.Images[0].Data : o.OrderItems.First().Product.ImgURL
            }));

            response.Data= orderResponse;
            response.Success= true;

            return response;

        }
    }
}

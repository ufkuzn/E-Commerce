using EC.Basket.Dtos;

namespace EC.Basket.Services.Abstract
{
    public interface IBasketService
    {
        Task<BasketTotalDto> GetBasket(string UserId);
        Task SaveBasket(BasketTotalDto basketTotalDto);
        Task DeleteBasket(string UserId);
    }
}
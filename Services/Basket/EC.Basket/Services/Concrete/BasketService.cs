using EC.Basket.Dtos;
using EC.Basket.Services.Abstract;
using EC.Basket.Settings;
using System.Text.Json;

namespace EC.Basket.Services.Concrete
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task DeleteBasket(string UserId)
        {
            await _redisService.GetDb().KeyDeleteAsync(UserId);
        }

        public async Task<BasketTotalDto> GetBasket(string UserId)
        {
            var existBasket = await _redisService.GetDb().StringGetAsync(UserId);
            return JsonSerializer.Deserialize<BasketTotalDto>(existBasket);
        }

        public async Task SaveBasket(BasketTotalDto basketTotalDto)
        {
            await _redisService.GetDb().StringSetAsync(basketTotalDto.UserId, JsonSerializer.Serialize(basketTotalDto));
        }
    }
}
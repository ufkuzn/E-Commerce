using EC.Basket.Dtos;
using EC.Basket.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EC.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly ILoginService _loginService;

        public BasketsController(ILoginService loginService, IBasketService basketService)
        {
            _loginService = loginService;
            _basketService = basketService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBasket()
        {
            var values = await _basketService.GetBasket(_loginService.GetUserId);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> SaveBasket(BasketTotalDto basketTotalDto)
        {
            basketTotalDto.UserId = _loginService.GetUserId;
            await _basketService.SaveBasket(basketTotalDto);
            return Ok("Basket successfully saved.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBasket()
        {
            await _basketService.DeleteBasket(_loginService.GetUserId);
            return Ok("Basket successfully deleted.");
        }
    }
}
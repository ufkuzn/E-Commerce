using EC.Basket.Services.Abstract;

namespace EC.Basket.Services.Concrete
{
    public class LoginService : ILoginService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetUserId => _httpContextAccessor.HttpContext.User.FindFirst("sub").Value; //kullanıcının "sub" claimindeki değeri döndürür.
    }
}
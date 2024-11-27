using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace V2T.Services
{
    public class UserService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _signInManager = signInManager ?? throw new ArgumentNullException(nameof(signInManager));
        }

        public async Task<IdentityResult> CreateUserAsync(string email, string password)
        {
            var user = new IdentityUser { UserName = email, Email = email };
            return await _userManager.CreateAsync(user, password);
        }
    }
}

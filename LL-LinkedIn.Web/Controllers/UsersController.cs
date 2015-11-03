using System.Linq;
using System.Web.Mvc;
using LL_LinkedIn.Data;
using LL_LinkedIn.Web.ViewModels;

namespace LL_LinkedIn.Web.Controllers
{
    [Authorize]
    public class UsersController : BaseController
    {
        public UsersController(ILL_LinkedInData data) : base(data)
        {
        }

        public ActionResult Index(string username)
        {
            var user = this.Data
                .Users
                .All()
                .Where(u => u.UserName == username)
                .Select(UserViewModel.ViewModel)
                .FirstOrDefault();
            if (user == null)
            {
                return this.HttpNotFound("User does not exists!");
            }

            return this.View(user);
        }
    }
}
using WebApiSite.Models;
using System.Net;
using System.Web.Http;
using System.Web.Security;

namespace WebApiSite.Controllers
{
    [RoutePrefix("user")]
    public class UsersController : ApiController
    {
        [Route("login")]
        public IHttpActionResult PostLogin(UserLoginViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (user.Username == "admin" && user.Password == "123")
            {
                FormsAuthentication.RedirectFromLoginPage(user.Username, false);
                return StatusCode(HttpStatusCode.NoContent);
            }
            else
            {
                return StatusCode(HttpStatusCode.Unauthorized);
            }
        }

        [Route("logout")]
        [HttpGet][HttpPost]
        public void Logout()
        {
            FormsAuthentication.SignOut();
        }

        [Authorize]
        [Route("profile")]
        public IHttpActionResult GetProfile()
        {
            return Ok(User.Identity.Name);
        }
    }
}

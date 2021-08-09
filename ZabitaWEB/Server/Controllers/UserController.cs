using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Server.Controllers
{
    [AllowAnonymous]

    [Route("api/[controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        readonly UserManager<Personel> _userManager;
        public UserController(UserManager<Personel> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetUser()
        {
            var ss=_userManager.GetUserName(ClaimsPrincipal.Current);
            return ss;
        }
    }
}

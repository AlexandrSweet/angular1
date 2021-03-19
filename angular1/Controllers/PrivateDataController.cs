using BusinessLayer.Models;
using BusinessLayer.UserService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace angular1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PrivateDataController : ControllerBase
    {
        private readonly IUserService _userService;
        public PrivateDataController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "First secret data", "Second secret data" };
        }

        [HttpGet]
        [Authorize]
        [Route("get-users")]
        public List<User> GetAllUsers()
        {
            return _userService.GetAll();
        }
    }
}

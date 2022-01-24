using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAPIProject.Service.Repository;
using MyAPIProject.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUpAsync([FromBody]SignUpVM signUpVM)
        {
            var result = await _accountRepository.SignUpAsync(signUpVM);
            if(result.Succeeded)
            {
                return Ok(result.Succeeded);
            }

            return Unauthorized();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] SignInVM signInVM)
        {
            var result = await _accountRepository.LoginAsync(signInVM);
            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }

            return Ok(result);
        }
    }
}

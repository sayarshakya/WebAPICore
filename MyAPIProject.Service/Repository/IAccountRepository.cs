using Microsoft.AspNetCore.Identity;
using MyAPIProject.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAPIProject.Service.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpVM signUpVM);
        Task<string> LoginAsync(SignInVM signInVM);
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Server.Extensions
{
    public class CustomUserManager:UserManager<Personel>
    {

        public CustomUserManager(IUserStore<Personel> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<Personel> passwordHasher, IEnumerable<IUserValidator<Personel>> userValidators, IEnumerable<IPasswordValidator<Personel>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<Personel>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
       
        }

    

        protected override Task<PasswordVerificationResult> VerifyPasswordAsync(IUserPasswordStore<Personel> store, Personel user, string password)
        {

            var psvr= PasswordVerificationResult.Success;
            return Task.FromResult(psvr);
        }
    }
}

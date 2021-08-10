using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IUserService
    {
        Task<HttpResponseMessage> GetUser();
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private readonly HttpClient _httpClient;

        readonly UserManager<Personel> _userManager;
        public UserController(UserManager<Personel> userManager, HttpClient httpClient)
        {
            _userManager = userManager;
            _httpClient = httpClient;
        }

        /*[HttpGet]
        public async Task<ActionResult<string>> GetUser()
        {
            var ss=_userManager.GetUserName(ClaimsPrincipal.Current);
            return ss;
        }*/
        //[HttpGet]
        //public async Task<string> GetUser(string username ,string pass)
        //{

       
        //    _httpClient.DefaultRequestHeaders.Authorization= new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJ6YWJpdGFkYnNlcnZpY2V1c2VyIiwianRpIjoiMzVjOGJkMTMtNDk3Yi00ZWE2LWIwYjYtMjI4ZGRlZGM5ZDg2IiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoibGRhcCIsIm5iZiI6MTYyODU4NDM4NiwiZXhwIjoxNjMxMTc2Mzg2LCJpc3MiOiJkZGQiLCJhdWQiOiJzZGZkc2ZkcyJ9.WyK49qulJ_dJkF_ZBdkdZ2e4pBLIRE7ofclD5doCASA");
        //    //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://gauservices.ibb.gov.tr/api/LDAP/ValidateUser" ,new JsonContent(new { userName = 1, password = 2 }));
        //    //request.ContentType = "application/json"; 
        //   // request.Method = "POST";

        //    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
        //    {
        //        string json = "{\"userName\":\"oguzhan.ozturk\"," +
        //          "\"password\":\"aqswde321\"}";
        //         streamWriter.Write(json);
        //    }

        //    using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
        //    using (var streamReader = new StreamReader(response.GetResponseStream()))
        //    {
        //        var result = streamReader.ReadToEndAsync();
        //        string json = System.Text.Json.JsonSerializer.Deserialize<string>(result.Result);

        //        return json;
        //    }

        //}
    }
}

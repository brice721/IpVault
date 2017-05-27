using System;
using AutoMapper;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using API_Attempt.Services;
using API_Attempt.Services.Users;
using API_Attempt.Services.Users.Model;

namespace API_Attempt.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsersController : ApiController
    {
        // GET: api/Users
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [System.Web.Http.AllowAnonymous]
        [System.Web.Http.HttpGet]
        // GET: api/Users/5
        public JsonResult<UsersModel> Get(int id)
        {
            var authSvc = Locator.GetUsersService();

            return Json(authSvc.GetUsers(id));
        }

        [System.Web.Mvc.AllowAnonymous]
        [System.Web.Mvc.HttpPost]
        // POST: api/Users
        public string Post([FromBody] UsersModel value)
        {
            Locator.GetUsersService().AddUsers(value);

            return true.ToString();
        }

        // PUT: api/Users/5
        public string Put([FromBody] UsersModel value)
        {
            Locator.GetUsersService().UpdateUsers(value);

            return true.ToString();
        }

        // DELETE: api/Users/5
        public string Delete([FromBody] UsersModel value)
        {
            Locator.GetUsersService().RemoveUsers(value);

            return true.ToString();
        }
    }
}
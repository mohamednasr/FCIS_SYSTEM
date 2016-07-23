using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
using System.Web.Http.WebHost;
using System;
using System.Web.Http;
using System.Web.Http.Controllers;
using FCIS.API.APIModels;

namespace FCIS.API.APIControllers
{
    public class LoginController : ApiController
    {
        //
        // GET: /Login/
        [System.Web.Http.HttpGet]
        public string test()
        {
            return "connected";
        }
        [System.Web.Http.HttpPost]
        public string Login(LoginModel user)
        {
            if (user.Email == "mmm@mm.com" && user.Password == "11111111")
                return "true";
            else
            {
                return "false";
            }
        }

    }
}

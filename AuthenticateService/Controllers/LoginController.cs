using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticateService.Context;
using AuthenticateService.Models;
using AuthenticateService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace AuthenticateService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _repository;

        public LoginController(ILoginRepository repository)
        {
            _repository = repository;
        }


        // GET: api/Login


        [HttpGet]
        [Route("Validate/{id}/{password}")]
        public Token Get(string id,string password)
        {
            Userdtl obj = _repository.UserLogin(id,password);
            MentorDtl obj1 = _repository.MentorLogin(id, password);

            if (obj!=null)
            {
                return new Token() { message = "User", token = GetToken() ,username=obj.UserName,active=obj.Active,useid=obj.UserId};
            }
            else if(obj1!=null)
            {
                return new Token() { message = "Mentor", token = GetToken() ,username=obj1.MentorName,active=obj.Active,useid=obj1.MentorId};

            }
            else if (id=="Admin" && password=="Admin")
            {
                return new Token() { message = "Admin", token = GetToken() ,username="Admin"};

            }
            else
            {
                return new Token() { message = "Invalid User", token = "" };

            }
        }
        public string GetToken()
        {
            return "Yes";
        }
    }
}

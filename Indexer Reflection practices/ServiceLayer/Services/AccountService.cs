using ServiceLayer.Exceptions;
using ServiceLayer.Helpers.Constants;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AccountService : IAccountService
    {
        public string Register(string username, string email, string password)
        {
            try
            {
                var result = GetAllEmail();

                if (result.Contains(email))
                {
                    throw new RegisterExceptions(ResponseMessage.InvalidRegisterMessage);
                }

                return ResponseMessage.SuccessRegisterMessage;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            
        }


        List<string> GetAllEmail()
        {

            return new List<string>() { "pervin12@gmail.com", "ali@code.edu.az", "aqsin@code.edu.az" };
        
        }
    }
}

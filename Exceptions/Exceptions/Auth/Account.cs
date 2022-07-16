using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Auth
{
    public class AccountException: Exception
    {
        public AccountException(string message): base(message)
        {

        }
        
        
    }
}

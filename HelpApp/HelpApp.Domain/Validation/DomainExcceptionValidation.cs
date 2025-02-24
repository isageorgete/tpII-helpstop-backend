using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Domain.Validation
{
    public class DomainExcceptionValidation: Exception
    {
        public DomainExcceptionValidation(string error) : base(error)
        {

        }
        
           public static void When (bool hasError, string error)
        {
            if (hasError)
            {
                throw new DomainExcceptionValidation(error);
            }
        }
        

        
        
    }
}

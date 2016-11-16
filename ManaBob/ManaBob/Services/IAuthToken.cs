using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob.Services
{
    public interface IAuthToken
    {
        String  AccessToken { get; }
        String  Code { get; }

        Boolean IsValid();
    }

}

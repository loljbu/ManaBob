using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob.Services
{
    public interface IAuthService : IDisposable
    {
        IAuthToken Auth(string _id, string _pwd);
    }
}

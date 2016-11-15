using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace ManaBob.Services
{

    /// <summary>
    ///     Fake authentication token for test
    /// </summary>
    public sealed class FakeToken : IAuthToken
    {
        string id;

        public FakeToken(string _id)
        {
            if(_id.Length == 0){
                throw new ArgumentException();
            }
            id = _id;
        }

        string IAuthToken.AccessToken
        {
            get { return id; } 
        }

        string IAuthToken.Code
        {
            get { return id; }
        }

        bool IAuthToken.IsValid()
        {
            return true;
        }

    }

    /// <summary>
    ///     Fake authentication service for test
    /// </summary>
    public sealed class FakeAuth : IAuthService
    {
        IAuthToken IAuthService.Auth(string _id, string _pwd)
        {
            return new FakeToken(_id);
        }

        void IDisposable.Dispose()
        {
            return;
        }
    }

}

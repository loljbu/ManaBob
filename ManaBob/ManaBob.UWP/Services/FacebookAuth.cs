using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Facebook;
using ManaBob.Services;

namespace ManaBob.UWP.Services
{
    /// <summary>
    ///     Not implemented
    /// </summary>
    public class FBToken : IAuthToken
    {
        FacebookOAuthResult result;

        public FBToken()
        {
            throw new NotImplementedException();
        }

        string IAuthToken.AccessToken
        {
            get { return result.AccessToken; }
        }

        string IAuthToken.Code
        {
            get { return result.Code; }
        }

        bool IAuthToken.IsValid()
        {
            return result.IsSuccess;
        }

    }

    public class FBAuth : IAuthService
    {
        FacebookClient client;

        public FBAuth()
        {
            throw new NotImplementedException();
        }


        IAuthToken IAuthService.Auth(string _id, string _pwd)
        {
            return new FBToken();
        }

        void IDisposable.Dispose()
        {
            return;
        }
    }

}

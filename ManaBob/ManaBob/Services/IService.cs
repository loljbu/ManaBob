using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using ManaBob.Services;

namespace ManaBob
{

    // - Note
    //      Application에서 사용하는 System/Network 접점을
    //       제공하는 Mediator Interface
    interface IService
    {
        ILocalService Local { get; }
        INetService   Net   { get; }
    }

}// namespace ManaBob

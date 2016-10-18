using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ManaBob
{

    // - Note
    //      Object serialization/deserialization 
    // - Dependency
    //      `Newtonsoft.Json`
    // - Task
    //      Async operation support?
    public class Format
    {
        public Format()
        {
            // Context...
        }

        public T FromJson<T>(String _json)
        {
            return JsonConvert.DeserializeObject<T>(_json);
        }

        public String ToJson<T>(T _object)
        {
            return JsonConvert.SerializeObject(_object);
        }

    }

}// namespace ManaBob


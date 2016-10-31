using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ManaBob
{

    /// <summary>
    ///     Object serialization/deserialization with JSON
    /// </summary>
    /// <remarks>
    ///     `Newtonsoft.Json`
    /// </remarks>
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Newtonsoft.Json;

namespace ManaBob
{

    /// <summary>
    ///     Object serialization/deserialization with JSON.
    ///     Use `Mutex` to race possible race condition in
    ///     `Newtonsoft.Json` library
    /// </summary>
    /// <remarks>
    ///     `Newtonsoft.Json`
    /// </remarks>
    public class Format
    {
        public static T FromJson<T>(String _json)
        {
            var result = JsonConvert.DeserializeObject<T>(_json);
            return result;
        }

        public static String ToJson<T>(T _object)
        {
            var result = JsonConvert.SerializeObject(_object, Formatting.Indented);
            return result;
        }

    }

}// namespace ManaBob


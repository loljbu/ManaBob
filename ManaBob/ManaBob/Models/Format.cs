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
        static Mutex to_lock   = new Mutex();
        static Mutex from_lock = new Mutex();

        public Format()
        {
        }

        public T FromJson<T>(String _json)
        {
            from_lock.WaitOne();
            var result = JsonConvert.DeserializeObject<T>(_json);
            from_lock.ReleaseMutex();
            return result;
        }

        public String ToJson<T>(T _object)
        {
            to_lock.WaitOne();
            var result = JsonConvert.SerializeObject(_object);
            to_lock.ReleaseMutex();
            return result;
        }

    }

}// namespace ManaBob


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob
{

    /// <summary>
    ///     Mediator repository for specific types.
    /// </summary>
    public class Repo<T>
    {
        Dictionary<int, T> dict = new Dictionary<int, T>();

        /// <summary>
        ///     Resolve the T object with string key
        /// </summary>
        public T Resolve(String _key)
        {
            var key     = _key.GetHashCode();
            T   result  = default(T);

            dict.TryGetValue(key, out result);   
            return result;
        }

        /// <summary>
        ///     Resolve the T object with type name
        /// </summary>
        public T Resolve<KeyType>()
        {
            var key = typeof(KeyType).Name;
            return Resolve(key);
        }

        /// <summary>
        ///     Register the T object with string key
        /// </summary>
        public void Register(String _key, T _value)
        {
            if(_key == null || _key.Length == 0 || _value == null){
                return;
            }

            var key = _key.GetHashCode();
            dict.Add(key, _value);
        }

        /// <summary>
        ///     Register the T object with type name
        /// </summary>
        public void Register<KeyType>(T _value)
        {
            String _key = typeof(KeyType).Name;

            Register(_key, _value);
        }


        /// <summary>
        ///     Release the T object with string key
        /// </summary>
        public void Release(String _key)
        {
            var key     = _key.GetHashCode();
            dict.Remove(key);
        }

        /// <summary>
        ///     Release the T object with type name
        /// </summary>
        public void Release<KeyType>()
        {
            String _key = typeof(KeyType).Name;
            Release(_key);
        }

        /// <summary>
        ///     Check if the key is already registered 
        /// </summary>
        public Boolean Contains(String _key)
        {
            return dict.ContainsKey(_key.GetHashCode());
        }

        /// <summary>
        ///     Check if the key is already registered 
        /// </summary>
        public Boolean Contains<KeyType>()
        {
            String _key = typeof(KeyType).Name;
            return Contains(_key);
        }

        /// <summary>
        ///     Clear the repository
        /// </summary>
        public void Clear()
        {
            dict.Clear();
        }

    }

    /// <summary>
    ///     Generic Repository as Mediator.
    /// </summary>
    public class Repository
    {
        Dictionary<int, Object> dict = null;

        public Repository()
        {
            dict = new Dictionary<int, Object>();
        }

        public Object Resolve(String _key)
        {
            Object res = null;
            var Key = _key.GetHashCode();
            dict.TryGetValue(Key, out res);
            return res;
        }

        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T).Name);
        }

        public void Register(String _key, Object _obj)
        {
            var Key = _key.GetHashCode();
            dict.Add(Key, _obj);
        }

        public void Register<T>(T _object)
        {
            Register(typeof(T).Name, _object);
        }

        public void Release(String _key)
        {
            var Key = _key.GetHashCode();
            dict.Remove(Key);
        }

        public void Release<T>()
        {
            Release(typeof(T).Name);
        }

        public Boolean Contains(String _key)
        {
            return Resolve(_key) != null;
        }

        public Boolean Contains<T>()
        {
            return Contains(typeof(T).Name);
        }

    }

}

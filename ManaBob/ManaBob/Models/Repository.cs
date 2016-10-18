using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob
{
    class Repository
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

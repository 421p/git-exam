using System;
using Newtonsoft.Json;

namespace git_exam.Factory {
    public class StorageItemFactory {
        public Tuple<string, string> Pack(object obj)
        {
            var key = obj.GetType().FullName;
            var value = JsonConvert.SerializeObject(obj);

            return new Tuple<string, string>(key, value);
        }

        public T Unpack<T>(string fqcn, string json)
        {
            return (T) JsonConvert.DeserializeObject(json, Type.GetType(fqcn));
        }

        public object Unpack(string fqcn, string json)
        {
            return JsonConvert.DeserializeObject(json, Type.GetType(fqcn));
        }
    }
}
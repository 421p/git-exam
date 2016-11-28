using System;
using System.Collections.Generic;
using System.Linq;
using git_exam.Factory;

namespace git_exam {
    public class ObjectProxy {
        private readonly StorageItemFactory _factory;
        private readonly List<Tuple<string, string>> _objects;

        public ObjectProxy()
        {
            _factory = new StorageItemFactory();
            _objects = new List<Tuple<string, string>>();
        }

        public void LoadOne(object obj)
        {
            _objects.Add(_factory.Pack(obj));
        }

        public object[] GetAll()
        {
            return _objects.ToList().Select(x => _factory.Unpack(x.Item1, x.Item2)).ToArray();
        }
    }
}
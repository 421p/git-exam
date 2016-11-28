using System.Collections.Generic;
using System.IO;
using git_exam.Person;
using git_exam.Vehicles;
using YamlDotNet.Serialization;

namespace git_exam.Reader {
    public class CarsReader : AbstractGetter<List<Car>> {
        public override List<Car> Get()
        {
            var deserializer = new Deserializer();
            return deserializer.Deserialize<List<Car>>(File.ReadAllText("../../cars.yml"));
        }
    }
}
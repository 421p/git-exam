using Newtonsoft.Json;
using YamlDotNet.Serialization;

namespace git_exam.Person {
    public class Hooman : IPerson {
        [YamlMember(Alias = "name")]
        public string Name { get; set; }
        [YamlMember(Alias = "surname")]
        public string Surname { get; set; }

        [YamlIgnore]
        [JsonIgnore]
        public string FullName => $"{Name} {Surname}";

        public override string ToString()
        {
            return FullName;
        }
    }
}
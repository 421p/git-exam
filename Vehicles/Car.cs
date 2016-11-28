using YamlDotNet.Serialization;

namespace git_exam.Vehicles {
    public class Car {
        [YamlMember(Alias = "model")]
        public string Model { get; set; }
        [YamlMember(Alias = "price")]
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Model} {Price}";
        }
    }
}
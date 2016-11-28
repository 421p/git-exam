using System;
using System.Linq;
using git_exam.Animals;
using git_exam.Factory;
using git_exam.Reader;

namespace git_exam {
    internal class Program {
        public static void Main(string[] args)
        {
            var proxy = new ObjectProxy();

            var carsReader = new CarsReader();
            var personReader = new PersonsReader();

            carsReader.Get().ForEach(proxy.LoadOne);
            personReader.Get().ForEach(proxy.LoadOne);

            proxy.GetAll().ToList().ForEach(Console.WriteLine);
        }
    }
}
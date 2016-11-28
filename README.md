# Git stupid example

We have a not working example of serializer and going to make it great again, so the task is:

1. fork and clone this repo.
2. Let's start from `packer` branch. jump to it.
3. merge `master` into `packer` and resolve conflicts
4. merge `car` into `packer` and also resolve conflicts 
5. get `cars.yml` from `car-list` branch without merging anything.
6. check if there is no implicit conflicts left
7. override `ToString` method in `Hooman` and `Car`
8. Add `ObjectProxy` class, it should looks like that:

```c#
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
```


then in `Program.cs` add something to test your code:

```c#
public static void Main(string[] args)
{
    var proxy = new ObjectProxy();

    var carsReader = new CarsReader();
    var personReader = new PersonsReader();

    carsReader.Get().ForEach(proxy.LoadOne);
    personReader.Get().ForEach(proxy.LoadOne);

    proxy.GetAll().ToList().ForEach(Console.WriteLine);
}
```
9. rename branch `packer` into `packer-your-name` where your name is your name
10. push it to origin and submit a pull request to the `mackerels:gix-exam`

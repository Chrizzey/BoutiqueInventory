using BoutiqueInventory.Articles;

namespace BoutiqueInventory;

internal class DummyInventory
{
    private static readonly string[] Colors = { "Red", "Green", "Blue", "Black", "White" };
    private static readonly string[] Materials = { "Cloth", "Leather" };

    private int _lastId;
    private readonly Random _random;

    public DummyInventory()
    {
        _random = new Random();
        _lastId = 0;
    }

    public void Fill(IInventory inventory)
    {
        var testInventory = CreateShoesForMen()
            .Concat(CreateShoesForWomen())
            .Concat(CreateHats())
            .Concat(CreateSocks())
            .Concat(CreateShirtsForMen())
            .Concat(CreateBlousesForWomen());

        foreach (var item in testInventory)
        {
            inventory.AddArticle(item);
        }
    }

    private IEnumerable<Article> CreateShoesForMen()
    {
        for (var i = 0; i < _random.Next(5, 16); i++)
        {
            yield return new MensShoe
            {
                Number = _lastId += 3,
                Color = Colors[_lastId % Colors.Length],
                Price = new decimal(_random.Next(0, 100) / 100f + _random.Next(9, 100)),
                HasLaces = _random.Next() % 2 == 0,
                Size = _random.Next(38, 51),
                Material = Materials[0]
            };
        }
    }

    private IEnumerable<Article> CreateShoesForWomen()
    {
        for (var i = 0; i < _random.Next(5, 16); i++)
        {
            yield return new WomensShoe()
            {
                Number = _lastId += 5,
                Color = Colors[_lastId % Colors.Length],
                Price = new decimal(_random.Next(0, 100) / 100f + _random.Next(9, 100)),
                HeelHeight = _random.Next(0, 20),
                Size = _random.Next(30, 43),
                Material = Materials[1]
            };
        }
    }

    private IEnumerable<Article> CreateHats()
    {
        for (var i = 0; i < _random.Next(2, 8); i++)
        {
            yield return new Hat
            {
                Number = ++_lastId,
                Color = Colors[_lastId % Colors.Length],
                Price = new decimal(_random.Next(0, 100) / 100f + _random.Next(9, 100)),
                Size = _random.Next(30, 80),
                Material = Materials[0]
            };
        }
    }

    private IEnumerable<Article> CreateSocks()
    {
        for (var i = 0; i < _random.Next(1, 18); i++)
        {
            yield return new Socks
            {
                Number = _lastId += 13,
                Color = Colors[_lastId % Colors.Length],
                Price = new decimal(_random.Next(0, 100) / 100f + _random.Next(9, 100)),
                Size = _random.Next(30, 51),
                Material = Materials[0],
                PackageSize = _random.Next(1, 11) * 2
            };
        }
    }

    private IEnumerable<Article> CreateShirtsForMen()
    {
        var shirtSizes = Enum.GetValues<ShirtSize>();

        for (var i = 0; i < _random.Next(1, 18); i++)
        {
            yield return new MensShirt()
            {
                Number = _lastId += 11,
                Color = Colors[_lastId % Colors.Length],
                Price = new decimal(_random.Next(0, 100) / 100f + _random.Next(9, 100)),
                Size = shirtSizes[_lastId % shirtSizes.Length],
                Material = Materials[0],
                SleeveLength = _random.Next(20, 100)
            };
        }
    }

    private IEnumerable<Article> CreateBlousesForWomen()
    {
        for (var i = 0; i < _random.Next(1, 18); i++)
        {
            yield return new WomensBlouse
            {
                Number = _lastId += 7,
                Color = Colors[_lastId % Colors.Length],
                Price = new decimal(_random.Next(0, 100) / 100f + _random.Next(9, 100)),
                Size = _random.Next(30, 55),
                Material = Materials[0],
                SleeveLength = _random.Next(20, 100)
            };
        }
    }
}
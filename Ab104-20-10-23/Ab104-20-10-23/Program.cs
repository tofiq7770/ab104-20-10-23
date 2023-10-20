
using Ab104_20_10_23;
using System;
using System.Reflection;





Fruit[] Basket = new Fruit[]
        {
            new Apple { Price = 2.5M, Sort = "Red", VitaminA = 10, VitaminB = 5 },
            new Apple { Price = 3.5M, Sort = "Red", VitaminA = 10, VitaminB = 5 },
            new Apple { Price = 4.5M, Sort = "Red", VitaminA = 10, VitaminB = 5 },
            new Pineapple { Price = 3.2M, Sort = "Sweet", VitaminE = 8, VitaminD = 3 },
            new Pineapple { Price = 4.2M, Sort = "Sweet", VitaminE = 8, VitaminD = 3 },
            new Pineapple { Price = 5.2M, Sort = "Sweet", VitaminE = 8, VitaminD = 3 },
            new Orange { Price = 1.8M, Sort = "Citrus", VitaminC = 7 },
            new Orange { Price = 2.8M, Sort = "Citrus", VitaminC = 7 },
            new Orange { Price = 3.8M, Sort = "Citrus", VitaminC = 7 }
        };

foreach (var fruit in Basket)
{
    Type type = fruit.GetType();
    Console.WriteLine(type.Name + ":");

    PropertyInfo[] properties = type.GetProperties();
    foreach (var property in properties)
    {
        if (property.CanRead)
        {
            object value = property.GetValue(fruit);
            Console.WriteLine($"{property.Name}: {value}");
        }
    }
    Console.WriteLine();
}

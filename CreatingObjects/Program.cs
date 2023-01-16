using CreatingObjects;

Price price = Price.Create(100);
Price price2 = Price.Create(100);
Console.WriteLine(price);
Console.WriteLine(price.Equals(price2));
Console.WriteLine($"{price.GetHashCode()} == {price2.GetHashCode()}");
Console.WriteLine(price+price2);
Console.WriteLine(price-price2);
Console.WriteLine(price*price2);
Console.WriteLine(price/price2);
Price price3 = Price.Create(2);
Console.WriteLine("Price2");
Console.WriteLine(price.Equals(price2));
Console.WriteLine(price == price2);
Console.WriteLine("Price3");
Console.WriteLine(price.Equals(price3));
Console.WriteLine(price == price3);
Console.WriteLine(price != price3);
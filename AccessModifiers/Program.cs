using AccessModifiers;

var item = new Item();
item.Name = "abc";
item.SetId(-100);
Console.WriteLine($"Item id= {item.GetId()}");
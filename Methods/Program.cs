using Methods;

ItemService.Create();
ItemService itemService = new ItemService();
Item item = CreateDefaultItem();
Console.WriteLine(itemService.Add(item: item));

foreach (Item itemInList in itemService.Items)
{
    Console.WriteLine($"Item: id={itemInList.Id} name={itemInList.Name}");
}

item.Name = "Test";
itemService.Update(item);


foreach (Item itemInList in itemService.Items)
{
    Console.WriteLine($"Item: id={itemInList.Id} name={itemInList.Name}");
}
static Item CreateDefaultItem()
{
    return new Item() { Name = "Item#" };
}

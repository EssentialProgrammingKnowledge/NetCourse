namespace Methods
{
    internal class ItemService
    {
        public List<Item> Items { get; } = new();

        public static void Create() 
        { 

        }

        public static int GetItemCount() 
        {
            return 0; 
        }

        public int Add(Item item, string description = "")
        {
            int id;
            if (Items.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = Items[Items.Count - 1].Id + 1;
            }

            item.Id = id;
            Items.Add(item);
            if (!string.IsNullOrWhiteSpace(description))
            {
                Console.WriteLine($"Description Item={description}");
            }
            return id;
        }

        public void Update(Item item)
        {
            foreach (Item itemInList in Items)
            {
                if (itemInList.Id == item.Id)
                {
                    itemInList.Name = item.Name;
                    return;
                }
            }
        }
    }
}

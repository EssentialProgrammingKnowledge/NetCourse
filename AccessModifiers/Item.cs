namespace AccessModifiers
{
    public class Item
    {
        public string? Name { get; set; }
        private int Id { get; set; }

        public void SetId(int id)
        {
            if (id < 0)
            {
                Id = 1000;
                return;
            }

            Id = id;
        }

        public int GetId()
        {
            return Id;
        }
    }
}

namespace FieldsAndProperties
{
    internal class Item
    {
        private string name = "";
        public int Id { get; }
        public string Name { get 
            { 
                return name;
            }
            set 
            { 
                name = value;
            }
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}

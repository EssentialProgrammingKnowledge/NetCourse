namespace ContainerIoC
{
    internal interface IItemService
    {
        void AddItem(Item item);
        bool DeleteItem(Guid id);
    }
}

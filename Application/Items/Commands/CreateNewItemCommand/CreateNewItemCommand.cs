using StdCatalog.Domain.Entities;
using StdCatalog.Application.Items.Commands.CreateNewItemCommand.Factory;
using StdCatalog.Persistence.Repositories;

namespace StdCatalog.Application.Items.Commands.CreateNewItemCommand
{
    public class CreateNewItemCommand : ICreateNewItemCommand
    {
        private readonly IRepository<Item>  _itemRepository;

        public CreateNewItemCommand(IRepository<Item> itemRepository)
        {
            _itemRepository = itemRepository;
        }


        public void Execute(CreateNewItemModel itemModel)
        {

            Item item;

            ItemFactory _factory = new ItemFactory();

            item =_factory.Create(itemModel.ItemCode, itemModel.ItemDescription);

            _itemRepository.Insert(item);
        }
    }
}
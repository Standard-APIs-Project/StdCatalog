using StdCatalog.Domain.Entities;
using StdCatalog.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdCatalog.Application.Items.Queries.GetAllItemsQuery
{
    public class GetAllItemsQuery : IGetAllItemsQuery
    {

        private readonly IRepository<Item> _itemRepository;

        public GetAllItemsQuery(IRepository<Item> itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public IEnumerable<Item> Execute()
        {
            return _itemRepository.GetAll();
        }

    }
}

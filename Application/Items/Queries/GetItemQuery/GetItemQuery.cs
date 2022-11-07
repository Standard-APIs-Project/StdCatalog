using StdCatalog.Domain.Entities;
using StdCatalog.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Items.Queries.GetItemQuery
{
    public class GetItemQuery : IGetItemQuery
    {

        private readonly IRepository<Item> _itemRepository;

        public GetItemQuery(IRepository<Item> itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public Item Execute(Guid id)
        {
            return _itemRepository.Get(id);
        }
    }
}

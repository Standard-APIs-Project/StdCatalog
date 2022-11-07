using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StdCatalog.Domain.Entities;


namespace StdCatalog.Persistence.Repositories.Items
{
    public class ItemRepository : IRepository<Item>
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Item entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Item entity)
        {
            throw new NotImplementedException();
        }
    }
}

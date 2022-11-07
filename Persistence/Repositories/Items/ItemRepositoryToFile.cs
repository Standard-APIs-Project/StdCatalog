using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StdCatalog.Domain.Entities;
using StdFilePersistence;

namespace StdCatalog.Persistence.Repositories.Items
{
    public class ItemRepositorytoFile : IRepository<Item>
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
            WriteToFile x = new WriteToFile();

            x.Execute<Item>("ItemRepository", entity);
        }

        public void Update(Item entity)
        {
            throw new NotImplementedException();
        }
    }
}

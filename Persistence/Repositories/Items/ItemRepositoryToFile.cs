using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using StdCatalog.Domain.Entities;
using StdFilePersistence;

namespace StdCatalog.Persistence.Repositories.Items
{
    public class ItemRepositorytoFile : IRepository<Item>
    {
        private readonly IConfiguration _configuration;
        private readonly IEntityToFile _entityTofile;

        public ItemRepositorytoFile(IConfiguration configuration, IEntityToFile entityTofile)
        {
            _configuration= configuration;
            _entityTofile = entityTofile;

        }


        private void UpdateCreateItem(Item entity)
        {

            _entityTofile.Write<Item>(entity);

        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item Get(Guid id)
        {

            return _entityTofile.Read<Item>(id);

        }

        public IEnumerable<Item> GetAll()
        {
            return _entityTofile.ReadAll<Item>();
        }

        public void Insert(Item entity)
        {
            UpdateCreateItem(entity);
        }

        public void Update(Item entity)
        {
            UpdateCreateItem(entity);
        }
    }
}

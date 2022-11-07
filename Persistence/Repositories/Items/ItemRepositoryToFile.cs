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

        public ItemRepositorytoFile(IConfiguration configuration)
        {
            _configuration= configuration;

        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item Get(Guid id)
        {
            WriteToFile x = new WriteToFile(_configuration);

            return x.Read<Item>("ItemRepository", id);

        }

        public IEnumerable<Item> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Item entity)
        {
            WriteToFile x = new WriteToFile(_configuration);

            x.Execute<Item>("ItemRepository", entity);
        }

        public void Update(Item entity)
        {
            throw new NotImplementedException();
        }
    }
}

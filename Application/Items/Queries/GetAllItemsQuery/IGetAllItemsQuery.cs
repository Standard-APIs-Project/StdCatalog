using StdCatalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdCatalog.Application.Items.Queries.GetAllItemsQuery
{
    public interface IGetAllItemsQuery
    {
        public IEnumerable<Item> Execute();
    }
}

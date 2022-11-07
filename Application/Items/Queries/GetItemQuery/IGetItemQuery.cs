using StdCatalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Items.Queries.GetItemQuery
{
    public interface IGetItemQuery
    {
        Item Execute(Guid id);
    }
}

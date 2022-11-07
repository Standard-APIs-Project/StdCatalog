using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StdCatalog.Domain.Entities;

namespace StdCatalog.Application.Items.Commands.CreateNewItemCommand.Factory
{
    public interface IItemFactory
    {
        Item Create(string Code, string Description);
    }
}

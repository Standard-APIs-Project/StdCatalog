using StdCatalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdCatalog.Application.Items.Commands.CreateNewItemCommand.Factory
{
    public class ItemFactory : IItemFactory
    {
        public Item Create(string Code, string Description)
        {
            var item = new Item(Code,Description);

            return item;
        }
    }
}

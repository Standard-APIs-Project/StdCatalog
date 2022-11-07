using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdCatalog.Application.Items.Commands.CreateNewItemCommand
{
    public interface ICreateNewItemCommand
    {

        void Execute(CreateNewItemModel model); 

    }
}

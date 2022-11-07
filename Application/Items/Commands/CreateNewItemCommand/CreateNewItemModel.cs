using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdCatalog.Application.Items.Commands.CreateNewItemCommand
{
    public class CreateNewItemModel
    {

        public string ItemCode { get; set; } = String.Empty;

        public string ItemDescription { get; set; } = String.Empty;

    }
}

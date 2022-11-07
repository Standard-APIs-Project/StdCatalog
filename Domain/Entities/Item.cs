using StandardAPIs.DomainBase;


namespace StdCatalog.Domain.Entities
{
    public class Item : DomainEntityBase
    {
        public string ItemCode { get; set; } = String.Empty;
        
        public string ItemDescription { get; set; } = String.Empty;


        public Item(string itemCode, string itemDescription)
        {
            Id = Guid.NewGuid();
            ItemCode = itemCode;
            ItemDescription = itemDescription;
        }

    }


}
using System;
using System.Collections.Generic;

namespace UkraineWebClient.Models
{
    public partial class Deal
    {
        public Deal()
        {
            this.AreaShopDeals = new List<AreaShopDeal>();
            this.BasketItems = new List<BasketItem>();
            this.DealCategories = new List<DealCategory>();
            this.DealPictures = new List<DealPicture>();
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public string ValidTo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal DealPrice { get; set; }
        public Nullable<int> UnitMeasureID { get; set; }
        public Nullable<decimal> Amont { get; set; }
        public Nullable<long> AreaShopSessionID { get; set; }
        public virtual ICollection<AreaShopDeal> AreaShopDeals { get; set; }
        public virtual ICollection<BasketItem> BasketItems { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }
        public virtual ICollection<DealCategory> DealCategories { get; set; }
        public virtual ICollection<DealPicture> DealPictures { get; set; }
    }
}

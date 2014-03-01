using System;
using System.Collections.Generic;

namespace UkraineWebClient.Models
{
    public partial class AreaShop
    {
        public AreaShop()
        {
            this.AreaShopDeals = new List<AreaShopDeal>();
        }

        public int ID { get; set; }
        public int AreaID { get; set; }
        public int ShopID { get; set; }
        public virtual Area Area { get; set; }
        public virtual ICollection<AreaShopDeal> AreaShopDeals { get; set; }
        public virtual Shop Shop { get; set; }
    }
}

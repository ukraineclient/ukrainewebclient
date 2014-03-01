using System;
using System.Collections.Generic;

namespace UkraineWebClient.Models
{
    public partial class AreaShopDeal
    {
        public long ID { get; set; }
        public int AreaShopID { get; set; }
        public long DealID { get; set; }
        public virtual AreaShop AreaShop { get; set; }
        public virtual Deal Deal { get; set; }
    }
}

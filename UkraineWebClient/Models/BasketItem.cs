using System;
using System.Collections.Generic;

namespace UkraineWebClient.Models
{
    public partial class BasketItem
    {
        public long ID { get; set; }
        public int BasketID { get; set; }
        public long DealID { get; set; }
        public int Amount { get; set; }
        public virtual Basket Basket { get; set; }
        public virtual Deal Deal { get; set; }
    }
}

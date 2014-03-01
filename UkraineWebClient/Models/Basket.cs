using System;
using System.Collections.Generic;

namespace UkraineWebClient.Models
{
    public partial class Basket
    {
        public Basket()
        {
            this.BasketItems = new List<BasketItem>();
        }

        public int ID { get; set; }
        public string UserID { get; set; }
        public string Name { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public virtual ICollection<BasketItem> BasketItems { get; set; }
    }
}

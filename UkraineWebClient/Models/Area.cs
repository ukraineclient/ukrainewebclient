using System;
using System.Collections.Generic;

namespace UkraineWebClient.Models
{
    public partial class Area
    {
        public Area()
        {
            this.AreaShops = new List<AreaShop>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AreaShop> AreaShops { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace UkraineWebClient.Models
{
    public partial class UnitMeasure
    {
        public UnitMeasure()
        {
            this.Deals = new List<Deal>();
        }

        public int ID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Abbriviation { get; set; }
        public virtual ICollection<Deal> Deals { get; set; }
    }
}

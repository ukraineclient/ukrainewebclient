using System;
using System.Collections.Generic;

namespace UkraineWebClient.Models
{
    public partial class DealCategory
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public long DealID { get; set; }
        public virtual Category Category { get; set; }
        public virtual Deal Deal { get; set; }
    }
}

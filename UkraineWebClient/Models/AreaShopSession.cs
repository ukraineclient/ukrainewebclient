using System;
using System.Collections.Generic;

namespace UkraineWebClient.Models
{
    public partial class AreaShopSession
    {
        public long Id { get; set; }
        public int AreaShopID { get; set; }
        public System.DateTime ValiFrom { get; set; }
        public string LockedBy { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
    }
}

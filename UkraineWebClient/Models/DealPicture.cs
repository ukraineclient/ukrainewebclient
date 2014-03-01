using System;
using System.Collections.Generic;

namespace UkraineWebClient.Models
{
    public partial class DealPicture
    {
        public long ID { get; set; }
        public long DealID { get; set; }
        public byte[] Image { get; set; }
        public virtual Deal Deal { get; set; }
    }
}

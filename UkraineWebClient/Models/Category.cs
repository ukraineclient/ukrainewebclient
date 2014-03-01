using System;
using System.Collections.Generic;

namespace UkraineWebClient.Models
{
    public partial class Category
    {
        public Category()
        {
            this.DealCategories = new List<DealCategory>();
        }

        public int ID { get; set; }
        public int Name { get; set; }
        public int ParentID { get; set; }
        public virtual ICollection<DealCategory> DealCategories { get; set; }
    }
}

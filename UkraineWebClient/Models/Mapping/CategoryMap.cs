using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UkraineWebClient.Models.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Categories");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
        }
    }
}

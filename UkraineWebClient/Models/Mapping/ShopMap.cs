using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UkraineWebClient.Models.Mapping
{
    public class ShopMap : EntityTypeConfiguration<Shop>
    {
        public ShopMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(75);

            // Table & Column Mappings
            this.ToTable("Shops");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}

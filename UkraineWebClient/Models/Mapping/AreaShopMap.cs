using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UkraineWebClient.Models.Mapping
{
    public class AreaShopMap : EntityTypeConfiguration<AreaShop>
    {
        public AreaShopMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("AreaShops");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.ShopID).HasColumnName("ShopID");

            // Relationships
            this.HasRequired(t => t.Area)
                .WithMany(t => t.AreaShops)
                .HasForeignKey(d => d.AreaID);
            this.HasRequired(t => t.Shop)
                .WithMany(t => t.AreaShops)
                .HasForeignKey(d => d.ShopID);

        }
    }
}

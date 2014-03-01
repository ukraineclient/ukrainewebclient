using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UkraineWebClient.Models.Mapping
{
    public class AreaShopDealMap : EntityTypeConfiguration<AreaShopDeal>
    {
        public AreaShopDealMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("AreaShopDeals");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AreaShopID).HasColumnName("AreaShopID");
            this.Property(t => t.DealID).HasColumnName("DealID");

            // Relationships
            this.HasRequired(t => t.AreaShop)
                .WithMany(t => t.AreaShopDeals)
                .HasForeignKey(d => d.AreaShopID);
            this.HasRequired(t => t.Deal)
                .WithMany(t => t.AreaShopDeals)
                .HasForeignKey(d => d.DealID);

        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UkraineWebClient.Models.Mapping
{
    public class BasketItemMap : EntityTypeConfiguration<BasketItem>
    {
        public BasketItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BasketItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BasketID).HasColumnName("BasketID");
            this.Property(t => t.DealID).HasColumnName("DealID");
            this.Property(t => t.Amount).HasColumnName("Amount");

            // Relationships
            this.HasRequired(t => t.Basket)
                .WithMany(t => t.BasketItems)
                .HasForeignKey(d => d.BasketID);
            this.HasRequired(t => t.Deal)
                .WithMany(t => t.BasketItems)
                .HasForeignKey(d => d.DealID);

        }
    }
}

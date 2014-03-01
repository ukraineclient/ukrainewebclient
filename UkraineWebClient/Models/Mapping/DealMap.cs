using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UkraineWebClient.Models.Mapping
{
    public class DealMap : EntityTypeConfiguration<Deal>
    {
        public DealMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.ValidTo)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Description)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Deal");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.DealPrice).HasColumnName("DealPrice");
            this.Property(t => t.UnitMeasureID).HasColumnName("UnitMeasureID");
            this.Property(t => t.Amont).HasColumnName("Amont");
            this.Property(t => t.AreaShopSessionID).HasColumnName("AreaShopSessionID");

            // Relationships
            this.HasOptional(t => t.UnitMeasure)
                .WithMany(t => t.Deals)
                .HasForeignKey(d => d.UnitMeasureID);

        }
    }
}

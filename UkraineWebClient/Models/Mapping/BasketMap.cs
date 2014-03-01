using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UkraineWebClient.Models.Mapping
{
    public class BasketMap : EntityTypeConfiguration<Basket>
    {
        public BasketMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Baskets");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
        }
    }
}

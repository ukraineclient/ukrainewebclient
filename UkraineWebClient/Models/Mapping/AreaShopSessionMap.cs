using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UkraineWebClient.Models.Mapping
{
    public class AreaShopSessionMap : EntityTypeConfiguration<AreaShopSession>
    {
        public AreaShopSessionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.LockedBy)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AreaShopSessions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AreaShopID).HasColumnName("AreaShopID");
            this.Property(t => t.ValiFrom).HasColumnName("ValiFrom");
            this.Property(t => t.LockedBy).HasColumnName("LockedBy");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
        }
    }
}

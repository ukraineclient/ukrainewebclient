using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UkraineWebClient.Models.Mapping
{
    public class UnitMeasureMap : EntityTypeConfiguration<UnitMeasure>
    {
        public UnitMeasureMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.Abbriviation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("UnitMeasures");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Abbriviation).HasColumnName("Abbriviation");
        }
    }
}

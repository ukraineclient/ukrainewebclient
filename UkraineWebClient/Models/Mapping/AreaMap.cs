using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UkraineWebClient.Models.Mapping
{
    public class AreaMap : EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(75);

            // Table & Column Mappings
            this.ToTable("Areas");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}

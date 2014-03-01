using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UkraineWebClient.Models.Mapping
{
    public class DealPictureMap : EntityTypeConfiguration<DealPicture>
    {
        public DealPictureMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Image)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("DealPictures");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DealID).HasColumnName("DealID");
            this.Property(t => t.Image).HasColumnName("Image");

            // Relationships
            this.HasRequired(t => t.Deal)
                .WithMany(t => t.DealPictures)
                .HasForeignKey(d => d.DealID);

        }
    }
}

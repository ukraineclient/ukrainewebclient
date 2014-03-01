using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UkraineWebClient.Models.Mapping
{
    public class DealCategoryMap : EntityTypeConfiguration<DealCategory>
    {
        public DealCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DealCategories");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.DealID).HasColumnName("DealID");

            // Relationships
            this.HasRequired(t => t.Category)
                .WithMany(t => t.DealCategories)
                .HasForeignKey(d => d.CategoryID);
            this.HasRequired(t => t.Deal)
                .WithMany(t => t.DealCategories)
                .HasForeignKey(d => d.DealID);

        }
    }
}

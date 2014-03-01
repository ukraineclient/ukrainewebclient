using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using UkraineWebClient.Models.Mapping;

namespace UkraineWebClient.Models
{
    public partial class DiscountsContext : DbContext
    {
        static DiscountsContext()
        {
            Database.SetInitializer<DiscountsContext>(null);
        }

        public DiscountsContext()
            : base("Name=DiscountsContext")
        {
        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<AreaShopDeal> AreaShopDeals { get; set; }
        public DbSet<AreaShop> AreaShops { get; set; }
        public DbSet<AreaShopSession> AreaShopSessions { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<DealCategory> DealCategories { get; set; }
        public DbSet<DealPicture> DealPictures { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<UnitMeasure> UnitMeasures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AreaMap());
            modelBuilder.Configurations.Add(new AreaShopDealMap());
            modelBuilder.Configurations.Add(new AreaShopMap());
            modelBuilder.Configurations.Add(new AreaShopSessionMap());
            modelBuilder.Configurations.Add(new BasketItemMap());
            modelBuilder.Configurations.Add(new BasketMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new DealMap());
            modelBuilder.Configurations.Add(new DealCategoryMap());
            modelBuilder.Configurations.Add(new DealPictureMap());
            modelBuilder.Configurations.Add(new ShopMap());
            modelBuilder.Configurations.Add(new UnitMeasureMap());
        }
    }
}

namespace COMP229_F2016_Lesson12.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCMusicStoreContext : DbContext
    {
        public MVCMusicStoreContext()
            : base("name=MVCMusicStoreConnection")
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        // New Features - Shopping Cart and Checkout
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    }
}

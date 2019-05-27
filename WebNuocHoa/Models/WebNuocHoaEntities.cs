namespace WebNuocHoa.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WebNuocHoaEntities : DbContext
    {
        public WebNuocHoaEntities()
            : base("name=WebNuocHoaEntities2")
        {
        }

        public virtual DbSet<CTDH> CTDHs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiSP> LoaiSPs { get; set; }
        public virtual DbSet<NhanHieu> NhanHieux { get; set; }
        public virtual DbSet<SP> SPs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTDH>()
                .Property(e => e.dongia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Taikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<SP>()
                .Property(e => e.Gia)
                .HasPrecision(18, 0);
        }
    }
}

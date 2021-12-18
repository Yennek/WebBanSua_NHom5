namespace CT_BTL_Nhom5_BanSua.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            ChinhSachUuDais = new HashSet<ChinhSachUuDai>();
            HoaDons = new HashSet<HoaDon>();
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        [Key]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(100)]
        public string TenKH { get; set; }

        [Required]
        [StringLength(20)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(10)]
        public string SoDienThoai { get; set; }

        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(25)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string DiaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChinhSachUuDai> ChinhSachUuDais { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}

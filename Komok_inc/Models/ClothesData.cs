namespace Komok_inc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClothesData")]
    public partial class ClothesData
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        public int Size { get; set; }

        [Required]
        public string Structure { get; set; }

        [Required]
        public string Style { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Brend { get; set; }

        public double Price { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [Required]
        [StringLength(100)]
        public string Category { get; set; }

        [Required]
        [StringLength(25)]
        public string Gender { get; set; }

        [Required]
        [StringLength(100)]
        public string ProviderTitle { get; set; }

        [Required]
        public byte[] Photo { get; set; }

        public virtual Category Category1 { get; set; }

        public virtual Gender Gender1 { get; set; }

        public virtual Provider Provider { get; set; }
    }
}

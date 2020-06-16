namespace Komok_inc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gender")]
    public partial class Gender
    {
        [Key]
        [Column("Gender")]
        [StringLength(25)]
        public string Gender1 { get; set; }
    }
}

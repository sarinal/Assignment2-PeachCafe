namespace Assignment2_PeachCafe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sweet")]
    public partial class Sweet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SweetId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(160)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Price { get; set; }
    }
}

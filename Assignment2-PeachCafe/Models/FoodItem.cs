namespace Assignment2_PeachCafe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodItem")]
    public partial class FoodItem
    {
        /// <summary>
        /// Constructor takes one argument name which sets the name propert to its value
        /// </summary>
        /// <param name="name"></param>
        public FoodItem(string name)
        {
            this.Name = name;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FoodItemId { get; set; }

        public int MenuCourseId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(160)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Price { get; set; }

        [StringLength(1024)]
        public string ImageUrl { get; set; }

        public virtual MenuCourse MenuCourse { get; set; }
    }
}

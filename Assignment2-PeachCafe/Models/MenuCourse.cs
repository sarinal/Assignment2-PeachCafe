namespace Assignment2_PeachCafe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MenuCourse")]
    public partial class MenuCourse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenuCourse()
        {
            FoodItems = new HashSet<FoodItem>();
        }

        
        /// <summary>
        /// Constructor takes one argument type string and assigns value to Name property
        /// </summary>
        /// <param name="name"></param>
        public MenuCourse(string name)
        {
            this.Name = name;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MenuCourseId { get; set; }

        //Foreign key fooditem
        

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodItem> FoodItems { get; set; }

    }
}

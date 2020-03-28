namespace Assignment3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Cost { get; set; }

        [Required]
        [StringLength(50)]
        public string MFG { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        [StringLength(50)]
        public string Memory { get; set; }

        [Required]
        [StringLength(50)]
        public string LCDSize { get; set; }

        [Required]
        [StringLength(50)]
        public string CPUBrand { get; set; }

        [Required]
        [StringLength(50)]
        public string CPUType { get; set; }

        [Required]
        [StringLength(50)]
        public string CPUNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string CPUSpeed { get; set; }

        [Required]
        [StringLength(50)]
        public string Condition { get; set; }

        [Required]
        [StringLength(50)]
        public string Platform { get; set; }

        [Required]
        [StringLength(50)]
        public string OS { get; set; }

        [Required]
        [StringLength(50)]
        public string HDD { get; set; }

        [Required]
        [StringLength(50)]
        public string GPUType { get; set; }

        [Required]
        [StringLength(50)]
        public string WebCam { get; set; }
    }
}

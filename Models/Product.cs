namespace JobApp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string productTitle { get; set; }

        public int? productAmount { get; set; }

        public int? productPrice { get; set; }  // te vajag decimal, bet DB man rajas ka nepatik vinjai tas decimal. tdel atstaju pagaidam int
    }
}

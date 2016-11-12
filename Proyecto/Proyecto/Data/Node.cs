namespace Proyecto.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Node")]
    public partial class Node
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int GraphId { get; set; }

        public virtual Graph Graph { get; set; }
    }
}

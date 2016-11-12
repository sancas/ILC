namespace Proyecto.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Edge")]
    public partial class Edge
    {
        public int Id { get; set; }

        [Required]
        public string NodoSalida { get; set; }

        [Required]
        public string NodoLlegada { get; set; }

        public int Value { get; set; }

        public int GraphId { get; set; }

        public virtual Graph Graph { get; set; }
    }
}

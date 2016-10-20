namespace Proyecto.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GraphSet")]
    public partial class GraphSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GraphSet()
        {
            NodeSets = new HashSet<NodeSet>();
        }

        public int Id { get; set; }

        [Required]
        public string Tipo { get; set; }

        public byte Background { get; set; }

        public byte NodeIcon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NodeSet> NodeSets { get; set; }
    }
}

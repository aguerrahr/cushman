namespace PPTReport.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tsg012_sist_incendio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tsg012_sist_incendio()
        {
            tsg009_ni_dt_gral = new HashSet<tsg009_ni_dt_gral>();
        }

        [Key]
        public int cd_sist_inc { get; set; }

        public string nb_sist_inc { get; set; }

        public DateTime? fh_modif { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tsg009_ni_dt_gral> tsg009_ni_dt_gral { get; set; }
    }
}

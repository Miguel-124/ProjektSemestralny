
namespace ProjektSemestralny
{
    using System;
    using System.Collections.Generic;
    
    public partial class Engines
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Engines()
        {
            this.Cars = new HashSet<Cars>();
        }

        public string Name { get; set; }
        public int Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cars> Cars { get; set; }
    }
}

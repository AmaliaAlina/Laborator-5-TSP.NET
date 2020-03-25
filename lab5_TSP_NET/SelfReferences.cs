using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_TSP_NET
{
    public class SelfReferences
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SelfReferenceId { get; private set; }
        public string Name { get; set; }
        public int? ParentSelfReferenceId { get; private set; }
        [ForeignKey("ParentSelfReferenceId")]
        public SelfReferences ParentSelfReference { get; set; }
        public virtual ICollection<SelfReferences> References { get; set; }
        public SelfReferences()
        {
            References = new HashSet<SelfReferences>();
        }

    }
}

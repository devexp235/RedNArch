using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RedNArch.Model.Interface;

namespace RedNArch.Model.Model
{
    public abstract class AuditibleEntity<T>: Entity<T>, IAuditibleEntity
    {
        //ScaffoldColumn(False) is used so that ASP.NET MVC scaffolding will not
        //generate controls for this in views. We will handle these properties
        //in context SaveChanges method.
        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }

        [ScaffoldColumn(false)]
        [MaxLength(256)]
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdatedDate { get; set; }

        [ScaffoldColumn(false)]
        [MaxLength(256)]
        public string UpdatedBy { get; set; }
    }
}

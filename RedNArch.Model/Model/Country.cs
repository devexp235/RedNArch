using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RedNArch.Model;

namespace RedNArch.Model.Model
{
    public class Country : Entity<int>
    {
        [Required]
        [MaxLength(100)]
        [Display(Name = "Country Name")]

        public virtual IEnumerable<Person> Persons { get; set; }
        public string Name { get; set; }
    }
}

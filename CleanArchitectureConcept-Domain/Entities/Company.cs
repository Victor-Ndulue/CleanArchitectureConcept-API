using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureConcept_Domain.Entities
{
    public class Company : BaseEntity
    {
            public string Name { get; set; }
            public string Address { get; set; }
            public string Country { get; set; }
            public ICollection<Employee> Employees { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureConcept_Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        [ForeignKey(nameof(Company))]
        public string CompanyId { get; set; }
        public Company Company { get; set; }
    }
}


using CleanArchitectureConcept_Domain.Entities;
using CleanArchitectureConcept_Infrastructure.Persistence.ApplicationDbContext;
using CleanArchitectureConcept_Infrastructure.RepositoryBase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureConcept_Infrastructure.RepositoryBase.Implementation
{
    internal class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(DataBaseContext context) : base(context)
        {
        }
    }
}

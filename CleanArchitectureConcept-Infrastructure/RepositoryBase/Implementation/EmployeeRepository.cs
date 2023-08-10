using CleanArchitectureConcept_Domain.Entities;
using CleanArchitectureConcept_Infrastructure.Persistence.ApplicationDbContext;
using CleanArchitectureConcept_Infrastructure.RepositoryBase.Interface;

namespace CleanArchitectureConcept_Infrastructure.RepositoryBase.Implementation
{
    internal class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DataBaseContext context) : base(context)
        {
        }
    }
}

using CleanArchitectureConcept_Infrastructure.RepositoryBase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureConcept_Infrastructure.UOW
{
    public interface IUnitOfWork
    {
        ICompanyRepository companyRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        Task SaveAsync();
    }
}

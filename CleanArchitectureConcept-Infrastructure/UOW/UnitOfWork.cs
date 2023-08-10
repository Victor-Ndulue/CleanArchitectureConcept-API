using CleanArchitectureConcept_Infrastructure.Persistence.ApplicationDbContext;
using CleanArchitectureConcept_Infrastructure.RepositoryBase.Implementation;
using CleanArchitectureConcept_Infrastructure.RepositoryBase.Interface;

namespace CleanArchitectureConcept_Infrastructure.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private IEmployeeRepository _employeeRepository;
        private ICompanyRepository _companyRepository;
        private DataBaseContext _dataBaseContext;
        public UnitOfWork(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public ICompanyRepository companyRepository
        {
            get
            {
                if ( _companyRepository == null ) {_companyRepository =new CompanyRepository(_dataBaseContext); return _companyRepository; }
                else return _companyRepository;
            }
        }


        public IEmployeeRepository EmployeeRepository => _employeeRepository??= new EmployeeRepository(_dataBaseContext);

        public async Task SaveAsync()
        {
           await _dataBaseContext.SaveChangesAsync();
        }
    }
}

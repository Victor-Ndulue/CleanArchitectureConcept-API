using CleanArchitectureConcept_Domain.Dtos.Requests;
using CleanArchitectureConcept_Domain.Dtos.Responses;
using CleanArchitectureConcept_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureConcept_Application.Services.Interfaces
{
    public interface ICompanyService
    {
        IEnumerable<CompanyResponseDto> GetAllCompany(bool trackChanges);
        Task<StandardResponse<CompanyResponseDto>> CreateCompanyAsync(CompanyRequestDto companyRequest);
    }
}

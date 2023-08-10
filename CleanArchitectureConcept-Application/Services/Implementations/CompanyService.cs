using AutoMapper;
using CleanArchitectureConcept_Application.Services.Interfaces;
using CleanArchitectureConcept_Domain.Dtos.Requests;
using CleanArchitectureConcept_Domain.Dtos.Responses;
using CleanArchitectureConcept_Domain.Entities;
using CleanArchitectureConcept_Infrastructure.UOW;
using Microsoft.Extensions.Logging;

namespace CleanArchitectureConcept_Application.Services.Implementations
{
    public class CompanyService:ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CompanyService> _logger;
        private readonly IMapper _mapper;

        public CompanyService(IUnitOfWork unitOfWork, ILogger<CompanyService> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<StandardResponse<CompanyResponseDto>> CreateCompanyAsync(CompanyRequestDto companyRequest)
        {
            if (companyRequest == null) { _logger.LogError("Company creation request cannot be null");
                return StandardResponse<CompanyResponseDto>.Failed("Company request is null");
            }
            _logger.LogInformation($"Attempting to create a new {companyRequest.Name} Company");
            Company company = _mapper.Map<Company>(companyRequest);
            await _unitOfWork.companyRepository.CreateAsync(company);
            _logger.LogInformation($"Company {company.Name} successfully created");
            await _unitOfWork.SaveAsync();
            _logger.LogInformation("Company successfully added to the database");
            CompanyResponseDto response = _mapper.Map<CompanyResponseDto>(company);
            return StandardResponse<CompanyResponseDto>.Success("Company Successfuly created", response, statusCode:200);
        }

        public IEnumerable<CompanyResponseDto> GetAllCompany(bool trackChanges)
        {
            IEnumerable<Company> companies = _unitOfWork.companyRepository.FindAll(trackChanges);
            var mappedCompanies = _mapper.Map<IEnumerable<CompanyResponseDto>>(companies) ;
            return mappedCompanies;
        }
    }
}

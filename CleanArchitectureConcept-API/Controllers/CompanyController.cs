using CleanArchitectureConcept_Application.Services.Interfaces;
using CleanArchitectureConcept_Domain.Dtos.Requests;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureConcept_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost]
        [Route ("create")]
        public  async Task<IActionResult> CreateCompanyAsync([FromBody]CompanyRequestDto companyRequestDto)
        {
            var Result = await _companyService.CreateCompanyAsync(companyRequestDto);
            return Ok(Result);
        }

        [HttpGet]
        [Route("view-all/companies")]
        public IActionResult GetAllCompanies(bool trackChanges)
        {
            var result = _companyService.GetAllCompany(trackChanges);
            return Ok(result);
        }
    }
}

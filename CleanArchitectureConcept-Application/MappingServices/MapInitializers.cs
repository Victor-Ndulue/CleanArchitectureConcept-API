using AutoMapper;
using CleanArchitectureConcept_Domain.Dtos.Requests;
using CleanArchitectureConcept_Domain.Dtos.Responses;
using CleanArchitectureConcept_Domain.Entities;

namespace CleanArchitectureConcept_Application.MappingServices
{
    public class MapInitializers:Profile
    {
        public MapInitializers()
        {
            CreateMap<CompanyRequestDto, Company>();
            CreateMap<Company,CompanyResponseDto>();
        }        
    }
}

using AutoMapper;
using QCapp.Models;
using QCapp.ViewModels;

namespace QCapp
{
    public class MappingProfile : Profile // this class inherits from AutoMapper profile class  
    {
        public MappingProfile()
        {
            CreateMap<State, StateViewModel>()
                .ForMember(d => d.StateId, opt => opt.MapFrom(s => s.Id)); 
            CreateMap<City, CityViewModel>()
                .ForMember(d => d.CityId, opt => opt.MapFrom(s => s.Id)); 
        }
    }
}

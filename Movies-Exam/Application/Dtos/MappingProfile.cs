using AutoMapper;
using Movies_Exam.Model;

namespace Movies_Exam.Application.Dtos
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<VisualContent, VisualContentDto>()
            .ForMember(x => x.TypeContent, y => y.MapFrom(z => z.TypeContent))
            .ForMember(x => x.Stadistics, y => y.MapFrom(y => y.Stadistics));
            CreateMap<Genre, GenreDto>();
            CreateMap<Language, LanguageDto>();
            CreateMap<Role, RoleDto>();
            CreateMap<Stadistics, StadisticsDto>();
            CreateMap<Staff, StaffDto>();
            CreateMap<TypeContent, TypeContentDto>();
            CreateMap<VisualContentGenre, VisualContentGenreDto>();
            CreateMap<VisualContentLanguage, VisualContentLanguageDto>();
            CreateMap<VisualContentStaff, VisualContentStaffDto>();
        }
    }
}

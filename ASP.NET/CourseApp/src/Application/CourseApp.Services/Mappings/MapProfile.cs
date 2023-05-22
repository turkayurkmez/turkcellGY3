using AutoMapper;
using CourseApp.DataTransferObjects.Responses;
using CourseApp.Entities;

namespace CourseApp.Services.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Course, CourseDisplayResponse>();
        }
    }
}

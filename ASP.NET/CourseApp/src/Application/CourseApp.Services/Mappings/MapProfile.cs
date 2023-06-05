using AutoMapper;
using CourseApp.DataTransferObjects.Requests;
using CourseApp.DataTransferObjects.Responses;
using CourseApp.Entities;

namespace CourseApp.Services.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Course, CourseDisplayResponse>();
            CreateMap<Category, CategoryDisplayResponse>();
            CreateMap<CreateNewCourseRequest, Course>();
            CreateMap<UpdateCourseRequest, Course>().ReverseMap();

        }
    }
}

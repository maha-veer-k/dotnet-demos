using AutoMapper;
using TestWebApi.API.Data;
using TestWebApi.API.Model;

namespace TestWebApi.API.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Books, BookModel>().ReverseMap();
        }
    }
}

using AutoMapper;
using BookStoreApp.Blazor.Server.UI.Services.Base;
using System.Runtime;

namespace BookStoreApp.Blazor.Server.UI.Configuration
{
    public class MapperConfig: Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorReadOnlyDto, AuthorUpdateDto>().ReverseMap();
        }
    }
}

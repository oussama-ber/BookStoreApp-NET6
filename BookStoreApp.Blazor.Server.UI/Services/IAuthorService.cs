using BookStoreApp.Blazor.Server.UI.Services.Base;

namespace BookStoreApp.Blazor.Server.UI.Services
{
    public interface IAuthorService
    {
        Task<Response<List<AuthorReadOnlyDto>>> GetAuthors();
        Task<Response<AuthorDetailsDto>> GetAuthor(int id);
        Task<Response<AuthorUpdateDto>> GetAuthorForUpdate(int id);
        Task CreateAuthor(AuthorCreateDto author);
        Task<Response<int>> UpdateAuthor(int id ,AuthorUpdateDto author);
        Task<Response<int>> Delete(int id);
    } 
}
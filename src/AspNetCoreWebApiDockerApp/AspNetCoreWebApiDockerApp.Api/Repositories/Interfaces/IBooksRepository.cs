using AspNetCoreWebApiDockerApp.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreWebApiDockerApp.Api.Repositories.Interfaces
{
    public interface IBooksRepository
    {
        Task<List<Book>> GetAll();
        Task<Book> Save(Book book);
        Task<Book> Get(string id);
        Task Update(Book book);
        Task Delete(string id);
    }
}

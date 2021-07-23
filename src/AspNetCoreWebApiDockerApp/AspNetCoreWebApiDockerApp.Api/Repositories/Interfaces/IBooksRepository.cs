using AspNetCoreWebApiDockerApp.Api.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreWebApiDockerApp.Api.Repositories.Interfaces
{
    public interface IBooksRepository
    {
        Task<List<Book>> GetAll();
        Task Save(Book book);
        Task<Book> Get(Guid id);
        Task Update(Book book);
        Task Delete(Guid id);
    }
}

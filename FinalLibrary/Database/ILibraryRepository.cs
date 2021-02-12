using System;
using System.Threading.Tasks;
using FinalLibrary.Entities;

namespace FinalLibrary.Database
{
    public interface ILibraryRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();

        Task<Book[]> GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(int id);
    }
}

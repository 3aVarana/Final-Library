using System;
using System.Threading.Tasks;

namespace FinalLibrary.Database
{
    public interface ILibraryRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();
    }
}

using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace FinalLibrary.Database
{
    public class LibraryRepositorySql : ILibraryRepository
    {
        private readonly LibraryContext _libraryContext;
        private readonly ILogger _logger;

        public LibraryRepositorySql(LibraryContext libraryContext, ILogger<LibraryRepositorySql> logger)
        {
            this._libraryContext = libraryContext;
            this._logger = logger;
        }

        public void Add<T>(T entity) where T : class
        {
            _logger.LogInformation($"Adding object of type {entity.GetType()} to context");
            _libraryContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _logger.LogInformation($"Removing object of type {entity.GetType()} from context");
            _libraryContext.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _libraryContext.SaveChangesAsync()) > 0;
        }
    }
}

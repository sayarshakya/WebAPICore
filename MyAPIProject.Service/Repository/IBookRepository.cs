using Microsoft.AspNetCore.JsonPatch;
using MyAPIProject.Service.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyAPIProject.Service.Repository
{
    public interface IBookRepository
    {
        Task<List<BooksVM>> GetAllBooksAsync();
        Task<BooksVM> GetBookByIdAsync(int bookId);
        Task<int> AddBookAsync(BooksVM model);
        Task UpdateBookAsync(int bookId, BooksVM model);
        Task UpdateBookPatchAsync(int bookId, JsonPatchDocument model);
        Task DeleteBookAsync(int bookId);
    }
}

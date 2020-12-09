using SampleWebAppWithViews.DTOs.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebAppWithViews.Interfaces
{
    public interface IBookService
    {
        Task<ReadBookDto> CreateBook(CreateBookDto book);
        Task<IEnumerable<ReadBookDto>> GetBooks();

        Task<ReadBookDto> GetBook(Guid id);

        Task SaveChangesAsync();
    }
}

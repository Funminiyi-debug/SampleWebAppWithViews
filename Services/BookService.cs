using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SampleWebAppWithViews.Data;
using SampleWebAppWithViews.DTOs.Book;
using SampleWebAppWithViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebAppWithViews.Interfaces
{
    public class BookService : IBookService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public BookService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ReadBookDto> CreateBook(CreateBookDto request)
        {
            Book book = _mapper.Map<Book>(request);

            var task = await _context.Books.AddAsync(book);

            ReadBookDto response = _mapper.Map<ReadBookDto>(task.Entity);

            return response;
        }

        public async Task<IEnumerable<ReadBookDto>> GetBooks()
        {
            IList<Book> books = await _context.Books.ToListAsync();

            var response = _mapper.Map<IList<ReadBookDto>>(books);

            return response;
        }


        public async Task<ReadBookDto> GetBook(Guid id)
        {
            Book book = await _context.Books.FindAsync(id);

            ReadBookDto response = _mapper.Map<ReadBookDto>(book);

            return response;
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

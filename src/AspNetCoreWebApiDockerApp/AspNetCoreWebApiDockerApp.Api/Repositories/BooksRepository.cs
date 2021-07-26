﻿using AspNetCoreWebApiDockerApp.Api.Models;
using AspNetCoreWebApiDockerApp.Api.Repositories.Context;
using AspNetCoreWebApiDockerApp.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreWebApiDockerApp.Api.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        private readonly LibraryContext _libraryContext;
        private readonly DbSet<Book> _books;

        public BooksRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
            _books = libraryContext.Books;
        }

        public async Task Delete(string id)
        {
            _books.Remove(new Book { Id = id });
            await SaveChanges();
        }

        public async Task<Book> Get(string id)
        {
            return await _books.FindAsync(id);
        }

        public async Task<List<Book>> GetAll()
        {
            return await _books.ToListAsync();
        }

        public async Task<Book> Save(Book book)
        {
            _books.Add(book);
            await SaveChanges();
            return book;
        }

        public async Task Update(Book book)
        {
            _books.Update(book);
            await SaveChanges();
        }

        private async Task<int> SaveChanges()
        {
            return await _libraryContext.SaveChangesAsync();
        }
    }
}

﻿using CarStore_DL.Interfaces;
using CarStore_Models.Models;
using CarStore_BL.Interfaces;

namespace CarStore_BL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void Add(Author author)
        {
            _authorRepository.Add(author);
        }

        public void Delete(int id)
        {
            _authorRepository.Delete(id);
        }

        public List<Author> GetAll()
        {
            return _authorRepository.GetAll();  
        }

        public Author? GetById(int id)
        {
            return _authorRepository.GetById(id);
        }
    }
}

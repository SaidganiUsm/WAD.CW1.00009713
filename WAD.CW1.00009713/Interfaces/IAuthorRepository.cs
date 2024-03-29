﻿using WAD.CW1._00009713.Dto;
using WAD.CW1._00009713.Models;

namespace WAD.CW1._00009713.Interfaces
{
    public interface IAuthorRepository
    {
        ICollection<Author> GetAll();
        Author GetById(int id);
        Author GetByName(string name);
        Author GetAuthorTrimToUpper(AuthorDto authorCreate);
        bool CreateAuthor(Author author);
        bool UpdateAuthor(Author author);
        bool DeleteAuthor(Author author);
        bool Save();
        bool IsExist(int id);
    }
}

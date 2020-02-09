using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogNews.API.Entities;

namespace BlogNews.API.Services
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> GetBlogs(Guid authorId);
        Blog GetBlog(Guid authorId, Guid blogId);
        void AddBlog(Guid authorId, Blog blog);
        void UpdateBlog(Blog blog);
        void DeleteBlog(Blog course);
        IEnumerable<Author> GetAuthors();
        Author GetAuthor(Guid authorId);
        IEnumerable<Author> GetAuthors(IEnumerable<Guid> authorIds);
        void AddAuthor(Author author);
        void DeleteAuthor(Author author);
        void UpdateAuthor(Author author);
        bool AuthorExists(Guid authorId);
        bool Save();
    }
}

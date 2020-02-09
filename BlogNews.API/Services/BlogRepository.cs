using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogNews.API.DbContexts;
using BlogNews.API.Entities;

namespace BlogNews.API.Services
{
    public class BlogRepository : IBlogRepository, IDisposable
    {
        private readonly BlogContext _context;
        public IEnumerable<Blog> GetBlogs(Guid authorId)
        {
            throw new NotImplementedException();
        }

        public Blog GetBlog(Guid authorId, Guid blogId)
        {
            throw new NotImplementedException();
        }

        public void AddBlog(Guid authorId, Blog blog)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog course)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAuthors()
        {
            throw new NotImplementedException();
        }

        public Author GetAuthor(Guid authorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAuthors(IEnumerable<Guid> authorIds)
        {
            throw new NotImplementedException();
        }

        public void AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void UpdateAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public bool AuthorExists(Guid authorId)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

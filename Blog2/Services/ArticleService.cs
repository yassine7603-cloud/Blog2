using Blog2.Models;
using Blog2.Models.Developpement_Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore; // Indispensable pour ToListAsync
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blog2.Data;
namespace Blog2.Services
{
    

    namespace Developpement_Blog.Services
    {
        public class ArticleService:Article
        {
            

            // 1. Déclarer la variable privée
        private readonly BlogDbContext _context;

            // 2. L'injecter via le constructeur
            public ArticleService(BlogDbContext context)
            {
                _context = context;
            }

            // 3. Ta méthode peut maintenant utiliser _context
            public async Task<List<Article>> GetAllArticlesAsync()
            {
                return await _context.Articles.ToListAsync();
            }


        private readonly List<Article> _articles = new();
            private int _nextId = 1;

            public List<Article> GetAll() => _articles;

            public Article? GetById(int id) => _articles.FirstOrDefault(a => a.Id == id);

            public void Create(string title, string content)
            {
                _articles.Add(new Article
                {
                    Id = _nextId++,
                    Title = title,
                    Content = content,
                    CreatedAt = DateTime.Now
                });
            }

            public bool Update(int id, string title, string content)
            {
                var art = GetById(id);
                if (art == null) return false;
                art.Title = title;
                art.Content = content;
                art.UpdatedAt = DateTime.Now;
                return true;
            }

            public bool Delete(int id) => _articles.RemoveAll(a => a.Id == id) > 0;
            public async Task<bool> DeleteArticleAsync(int id)
            {
                var article = await _context.Articles.FindAsync(id);
                if (article == null) return false;

                _context.Articles.Remove(article);
                await _context.SaveChangesAsync();
                return true;
            }
            public async Task<Article> CreateArticleAsync(Article article)
            {
                article.CreatedAt = DateTime.Now;
                article.UpdatedAt = DateTime.Now;
                _context.Articles.Add(article);
                await _context.SaveChangesAsync();
                return article;
            }
            // Mettre à jour un article
            public async Task<bool> UpdateArticleAsync(int id, Article updatedArticle)
            {
                var article = await _context.Articles.FindAsync(id);
                if (article == null) return false;

                article.Title = updatedArticle.Title;
                article.Content = updatedArticle.Content;
                article.UpdatedAt = DateTime.Now; // On met à jour la date automatiquement !

                await _context.SaveChangesAsync();
                return true;
            }
            public async Task<List<Article>> GetAllWithCommentsAsync()
            {
                // On dit explicitement à EF : "Va chercher l'article ET ses commentaires"
                return await _context.Articles
                    .Include(a => a.Comments)
                    .ToListAsync();
            }

            public async Task<Article?> GetByIdWithCommentsAsync(int id)
            {
                return await _context.Articles
                    .Include(a => a.Comments)
                    .FirstOrDefaultAsync(a => a.Id == id);
            }
        }
    }
}
